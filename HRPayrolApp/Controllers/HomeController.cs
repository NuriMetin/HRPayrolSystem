using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRPayrolApp.Models;
using Microsoft.AspNetCore.Identity;
using static HRPayrolApp.Models.SD;
using HRPayrolApp.DAL;
using Microsoft.EntityFrameworkCore;
using HRPayrolApp.Models.ViewModels;

namespace HRPayrolApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        private readonly UserManager<Worker> _userManager;
        private readonly SignInManager<Worker> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public HomeController(HRPayrollDbContext dbContext, UserManager<Worker> userManager, SignInManager<Worker> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public async Task MyRolesAddedAction()
        {
            if(!await _roleManager.RoleExistsAsync(Roles.Admin.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            }
            if (!await _roleManager.RoleExistsAsync(Roles.HR.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.HR.ToString()));
            }
            if(!await _roleManager.RoleExistsAsync(Roles.DepartmentHead.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.DepartmentHead.ToString()));
            }
            if(!await _roleManager.RoleExistsAsync(Roles.PayrollSpecalist.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.PayrollSpecalist.ToString()));
            }
            if(!await _roleManager.RoleExistsAsync(Roles.PayrollSpecalist.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.PayrollSpecalist.ToString()));
            }
            if(!await _roleManager.RoleExistsAsync(Roles.Worker.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.Worker.ToString()));
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About(string selectedDate)
        {
            if (selectedDate == null)
            {
                return NotFound();
            }
            var date = Convert.ToDateTime(selectedDate);
            var workers = _dbContext.Users.ToList();
            var user = await _dbContext.Users.Include(x => x.Employee).SingleOrDefaultAsync(x => _userManager.FindByNameAsync(User.Identity.Name).GetAwaiter().GetResult().Id == x.Id);
            var id = user.Id;
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

           
            SalaryModel salaryModel = new SalaryModel();

            salaryModel.AvialableWorkers = workers.Where(x => x.Id == id).Select(x => new AvialableWorker
            {
                Department = _dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Department.Name).FirstOrDefault(),
                ID = x.Id,
                Name = _dbContext.Employees.Where(y => y.Worker.Id == x.Id).Select(y => y.Name).FirstOrDefault(),
                IDCardNumber = _dbContext.Employees.Where(y => y.Worker.Id == x.Id)
                          .Select(y => y.IDCardNumber).FirstOrDefault(),

                Surname = _dbContext.Employees.Where(y => y.Worker.Id == x.Id).Select(y => y.Surname).FirstOrDefault(),
                Position = _dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Name).FirstOrDefault(),
                IsChecked = false,
                EmployeeId = x.EmployeeId,

                OldCalculate = date,

                Bonus = _dbContext.WorkerBonus.Where(y => y.WorkerId == x.Id && y.BonusDate.Year == date.Year && y.BonusDate.Month == date.Month).Sum(y => y.BonusSalary)
                       + _dbContext.CompanyWorkPlaceBonus.Include(m => m.CompanyWorkPlace)
                          .Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId && y.CompanyWorkPlace.ChangedDate.Year == date.Year && y.CompanyWorkPlace.ChangedDate.Month == date.Month).Select(y => y.BonusSalary).FirstOrDefault(),

                MonthlySalary = _dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Salary).FirstOrDefault(),

                ExcusableAbsens = _dbContext.WorkerAbsens.Where(y => y.AbsensId == 1 && y.WorkerId == x.Id && y.Date.Year == date.Year && y.Date.Month == date.Month).Count()
                          + _dbContext.CompanyWorkPlaceAbsens.Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId && y.CompanyWorkPlace.ChangedDate.Year == date.Year && y.CompanyWorkPlace.ChangedDate.Month == date.Month)
                              .Select(y => y.ExcusableAbsens).FirstOrDefault(),

                UnExcusableAbsens = _dbContext.WorkerAbsens.Where(y => y.AbsensId == 2 && y.WorkerId == x.Id && y.Date.Year == date.Year && y.Date.Month == date.Month).Count()
                          + _dbContext.CompanyWorkPlaceAbsens.Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId && y.CompanyWorkPlace.ChangedDate.Year == date.Year && y.CompanyWorkPlace.ChangedDate.Month == date.Month)
                              .Select(y => y.UnExcusableAbsens).FirstOrDefault(),

                AbsensCount = _dbContext.WorkerAbsens.Where(y => y.AbsensId == 1 && y.WorkerId == x.Id).Count()
                          + _dbContext.CompanyWorkPlaceAbsens.Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId)
                              .Select(y => y.ExcusableAbsens).FirstOrDefault()
                                  + _dbContext.WorkerAbsens.Where(y => y.AbsensId == 2 && y.WorkerId == x.Id).Count()
                                       + _dbContext.CompanyWorkPlaceAbsens.Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId)
                                          .Select(y => y.UnExcusableAbsens).FirstOrDefault(),

                TotalSalary = (_dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Salary).FirstOrDefault() - _dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Salary).FirstOrDefault() / daysInMonth
                               * _dbContext.WorkerAbsens.Where(y => y.AbsensId == 2 && y.WorkerId == x.Id && y.Date.Year == date.Year && y.Date.Month == date.Month).Count()
                                  + _dbContext.CompanyWorkPlaceAbsens.Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId && y.CompanyWorkPlace.ChangedDate.Year == date.Year && y.CompanyWorkPlace.ChangedDate.Month == date.Month)
                                      .Select(y => y.UnExcusableAbsens).FirstOrDefault())
                                          + _dbContext.WorkerBonus.Where(y => y.WorkerId == x.Id && y.BonusDate.Year == date.Year && y.BonusDate.Month == date.Month).Sum(y => y.BonusSalary)
                       + _dbContext.CompanyWorkPlaceBonus.Include(m => m.CompanyWorkPlace)
                          .Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId && y.CompanyWorkPlace.ChangedDate.Year == date.Year && y.CompanyWorkPlace.ChangedDate.Month == date.Month).Select(y => y.BonusSalary).FirstOrDefault()

            }).ToList();

            return View(salaryModel);
        }

        public async Task<IActionResult> Contact()
        {
            var user = await _dbContext.Users.Include(x => x.Employee).SingleOrDefaultAsync(x => _userManager.FindByNameAsync(User.Identity.Name).GetAwaiter().GetResult().Id == x.Id);
            var id = user.Id;

            var workers = await _dbContext.Users.ToListAsync();
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            int currentDay = DateTime.Now.Day;

            SalaryModel salaryModel = new SalaryModel();
            salaryModel.AvialableWorkers = workers.Where(x =>x.Id==id ).Select(x => new AvialableWorker
            {
                Department = _dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Department.Name).FirstOrDefault(),
                ID = id,
                Name = _dbContext.Employees.Where(y => y.Worker.Id == x.Id).Select(y => y.Name).FirstOrDefault(),
                IDCardNumber = _dbContext.Employees.Where(y => y.Worker.Id == x.Id)
                          .Select(y => y.IDCardNumber).FirstOrDefault(),

                Surname = _dbContext.Employees.Where(y => y.Worker.Id == x.Id).Select(y => y.Surname).FirstOrDefault(),
                Position = _dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Name).FirstOrDefault(),
                IsChecked = false,
                EmployeeId = x.EmployeeId,

                OldCalculate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),

                Bonus = _dbContext.WorkerBonus.Where(y => y.WorkerId == x.Id && y.BonusDate.Year == year && y.BonusDate.Month == month).Sum(y => y.BonusSalary)
                       + _dbContext.CompanyWorkPlaceBonus.Include(m => m.CompanyWorkPlace)
                          .Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId && y.CompanyWorkPlace.ChangedDate.Year == year && y.CompanyWorkPlace.ChangedDate.Month == month).Select(y => y.BonusSalary).FirstOrDefault(),

                MonthlySalary = _dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Salary).FirstOrDefault() / daysInMonth * currentDay,

                ExcusableAbsens = _dbContext.WorkerAbsens.Where(y => y.AbsensId == 1 && y.WorkerId == x.Id && y.Date.Year == year && y.Date.Month == month).Count()
                          + _dbContext.CompanyWorkPlaceAbsens.Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId && y.CompanyWorkPlace.ChangedDate.Year == year && y.CompanyWorkPlace.ChangedDate.Month == month)
                              .Select(y => y.ExcusableAbsens).FirstOrDefault(),

                UnExcusableAbsens = _dbContext.WorkerAbsens.Where(y => y.AbsensId == 2 && y.WorkerId == x.Id && y.Date.Year == year && y.Date.Month == month).Count()
                          + _dbContext.CompanyWorkPlaceAbsens.Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId && y.CompanyWorkPlace.ChangedDate.Year == year && y.CompanyWorkPlace.ChangedDate.Month == month)
                              .Select(y => y.UnExcusableAbsens).FirstOrDefault(),

                AbsensCount = _dbContext.WorkerAbsens.Where(y => y.AbsensId == 1 && y.WorkerId == x.Id).Count()
                          + _dbContext.CompanyWorkPlaceAbsens.Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId)
                              .Select(y => y.ExcusableAbsens).FirstOrDefault()
                                  + _dbContext.WorkerAbsens.Where(y => y.AbsensId == 2 && y.WorkerId == x.Id).Count()
                                       + _dbContext.CompanyWorkPlaceAbsens.Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId)
                                          .Select(y => y.UnExcusableAbsens).FirstOrDefault(),

                TotalSalary = (_dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Salary).FirstOrDefault() / daysInMonth * currentDay - _dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Salary).FirstOrDefault() / daysInMonth
                               * _dbContext.WorkerAbsens.Where(y => y.AbsensId == 2 && y.WorkerId == x.Id && y.Date.Year == year && y.Date.Month == month).Count()
                                  + _dbContext.CompanyWorkPlaceAbsens.Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId && y.CompanyWorkPlace.ChangedDate.Year == year && y.CompanyWorkPlace.ChangedDate.Month == month)
                                      .Select(y => y.UnExcusableAbsens).FirstOrDefault())
                                          + _dbContext.WorkerBonus.Where(y => y.WorkerId == x.Id && y.BonusDate.Year == year && y.BonusDate.Month == month).Sum(y => y.BonusSalary)
                       + _dbContext.CompanyWorkPlaceBonus.Include(m => m.CompanyWorkPlace)
                          .Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId && y.CompanyWorkPlace.ChangedDate.Year == year && y.CompanyWorkPlace.ChangedDate.Month == month).Select(y => y.BonusSalary).FirstOrDefault()

            }).ToList();

            return View(salaryModel);

          
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
