using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRPayrollSystem.DAL;
using HRPayrollSystem.Models;
using HRPayrollSystem.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRPayrollSystem.Controllers
{
    [Authorize]
    public class BonusController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        private readonly UserManager<Worker> _userManager;

        public BonusController(UserManager<Worker> userManager, HRPayrollDbContext dbContext)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        [Authorize(Roles = SD.DepartmentHead)]
        public async Task<IActionResult> WorkerList()
        {
            ViewBag.SkipCount = 6;
            var user = await _dbContext.Users.Where(x=>x.Working==true).Include(x => x.Position).SingleOrDefaultAsync(x => _userManager.FindByNameAsync(User.Identity.Name).GetAwaiter().GetResult().Id == x.Id);
            var id = user.Position.DepartmentId;
            var workers = await _dbContext.Users.ToListAsync();
            ViewBag.TotalCount = workers.Count();

            var data = await (from work in _userManager.Users
                              join emp in _dbContext.Employees
                              on work.EmployeeId equals emp.ID
                              join pos in _dbContext.Positions
                              on work.PositionId equals pos.ID
                              join dep in _dbContext.Departments
                              on pos.DepartmentId equals dep.ID
                              where dep.ID == id && work.Working==true
                              select new WorkersViewModel
                              {
                                  WorkerId = work.Id,
                                  Email = work.Email,
                                  Name = emp.Name,
                                  Surname = emp.Surname,
                                  Position = pos.Name,
                                  Department = dep.Name,
                                  BeginDate = work.BeginDate
                              }).Take(6).ToListAsync();

            return View(data);
        }

        [Authorize(Roles = SD.DepartmentHead)]
        [HttpGet]
        public async Task<IActionResult> AddBonus(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var workers = await _userManager.FindByIdAsync(id);
            AddBonus addBonus = new AddBonus
            {
                WorkerAccount = workers.Account,
                WorkerID = workers.Id
            };
            return View(addBonus);
        }

        [Authorize(Roles = SD.DepartmentHead)]
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

        [Authorize(Roles =SD.PayrollSpecalist)]
        public IActionResult StoreBonus(string selectedDate)
        {
            DateTime date = Convert.ToDateTime(selectedDate);
            SaleViewModel saleViewModel = new SaleViewModel();

            saleViewModel.AvialableStores = _dbContext.Stores.Select(y => new AvialableStores
            {
                SaleSalary = _dbContext.Sales.Where(x => x.Date.Year == date.Year && x.Date.Month == date.Month && x.StoreId == y.ID).Sum(x => x.SaleSalary),
                StoreName = y.Name,
                SelectedDate = date,
                StoreId = y.ID
            }).ToList();

            return View(saleViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        [Authorize(Roles = SD.PayrollSpecalist)]
        public IActionResult StoreBonus(decimal requiredSalary, decimal bonus, SaleViewModel saleView, int bonusform)
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
                var work = _dbContext.Users.Where(x=>x.Working==true).Include(x => x.Position).Where(x => x.StoreId == store.ID).ToList();
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
                    addBonus.Add(new WorkerBonus { BonusDate = DateTime.Now, BonusSalary = (work.Position.Salary) / 100 * bonus, Reason = "Good Sale", WorkerId = work.Id });
                }
            }

            _dbContext.WorkerBonus.AddRange(addBonus);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(WorkerList));
        }
    }
}