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
    }
}