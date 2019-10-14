using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HRPayrolApp.DAL;
using HRPayrolApp.Models;
using HRPayrolApp.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRPayrolApp.Controllers
{
    public class BonusController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        private readonly UserManager<Worker> _userManager;

        public BonusController(UserManager<Worker> userManager, HRPayrollDbContext dbContext)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task<IActionResult> WorkerList()
        {
            
            var user = await _dbContext.Users.Include(x => x.Position).SingleOrDefaultAsync(x => _userManager.FindByNameAsync(User.Identity.Name).GetAwaiter().GetResult().Id == x.Id);
            var id = user.Position.DepartmentId;
            var data = await (from work in _userManager.Users
                              join emp in _dbContext.Employees
                              on work.EmployeeId equals emp.ID
                              join pos in _dbContext.Positions
                              on work.PositionId equals pos.ID
                              join dep in _dbContext.Departments
                              on pos.DepartmentId equals dep.ID
                              where dep.ID == id
                              select new WorkersViewModel
                              {
                                  WorkerId = work.Id,
                                  Email = work.Email,
                                  Name = emp.Name,
                                  Surname = emp.Surname,
                                  Position = pos.Name,
                                  Department = dep.Name,
                                  BeginDate = work.BeginDate
                              }).ToListAsync();

            return View(data);
        }

        //[Authorize(Roles = SD.DepartmentHead)]
        [HttpGet]
        public async Task<IActionResult> AddBonus(string id)
        {
            var workers = await _userManager.FindByIdAsync(id);
            AddBonus addBonus = new AddBonus
            {
                WorkerAccount = workers.Account,
                WorkerID = workers.Id
            };
            return View(addBonus);
        }

        //[Authorize(Roles = SD.DepartmentHead)]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBonus(string id, AddBonus addBonus)
        {
            var workers = await _userManager.FindByIdAsync(id);
            if (!ModelState.IsValid)
            {
                addBonus.WorkerID = workers.Id;
                addBonus.WorkerAccount = workers.Account;
                return View(addBonus);
            }

            WorkerBonus bonus = new WorkerBonus
            {
                WorkerId = workers.Id,
                BonusSalary = addBonus.BonusSalary,
                BonusDate = DateTime.Now,
                Reason = addBonus.Reason
            };

            _dbContext.WorkerBonus.Add(bonus);

            _dbContext.SaveChanges();
            return RedirectToAction(nameof(WorkerList));
        }

        public IActionResult StoreBonus( string selectedDate)
        {


            DateTime date = Convert.ToDateTime(selectedDate);
            SaleViewModel saleViewModel = new SaleViewModel();

            saleViewModel.AvialableStores = _dbContext.Stores.Select(y => new AvialableStores
            {
                SaleSalary = _dbContext.Sales.Where(x => x.Date.Year == date.Year && x.Date.Month == date.Month && x.StoreId == y.ID).Sum(x => x.SaleSalary),
                StoreName = y.Name,
                SelectedDate = date,
                 StoreId=y.ID
            }).ToList();


            return View(saleViewModel);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult StoreBonus(decimal requiredSalary,decimal bonus, SaleViewModel saleView, int bonusform)
        {
            
            List<WorkerBonus> addBonus = new List<WorkerBonus>();
            List<Store> stores = new List<Store>();
            List<Worker> workers = new List<Worker>();

            foreach (var item in saleView.AvialableStores)
            {
                if (item.SaleSalary >= requiredSalary)
                {
                    var store = _dbContext.Stores.Where(x => x.ID == item.StoreId).ToList();
                    stores.AddRange(store);
                }
            }

            foreach (var store in stores)
            {
                var work = _dbContext.Users.Include(x=>x.Position).Where(x => x.StoreId == store.ID).ToList();
                workers.AddRange(work);
            }

            foreach (var work in workers)
            {
                if (bonusform == 1)
                {
                    addBonus.Add(new WorkerBonus { BonusDate = DateTime.Now, BonusSalary = bonus, Reason = "Good Sale", WorkerId = work.Id });
                }
                else
                    if (bonusform == 0)
                {
                    addBonus.Add(new WorkerBonus { BonusDate = DateTime.Now, BonusSalary = (work.Position.Salary)/100*bonus, Reason = "Good Sale", WorkerId = work.Id });
                }
            }

            _dbContext.WorkerBonus.AddRange(addBonus);
            _dbContext.SaveChanges();
           return RedirectToAction(nameof(WorkerList));
        }
    }
}