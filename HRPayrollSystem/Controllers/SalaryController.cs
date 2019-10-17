using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using HRPayrollSystem.DAL;
using HRPayrollSystem.Models;
using HRPayrollSystem.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HRPayrollSystem.Controllers
{
    [Authorize]
    public class SalaryController : Controller
    {

        private readonly HRPayrollDbContext _dbContext;
        private readonly UserManager<Worker> _userManager;

        public SalaryController(HRPayrollDbContext dbContext, UserManager<Worker> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        [Authorize(Roles =SD.PayrollSpecalist)]
        public async Task<IActionResult> WorkerSalary()
        {
            ViewBag.SkipCount = 5;
            var workers = await _dbContext.Users
               .Include(x => x.Position)
               .Include(x => x.Position.Department)
               .Include(x => x.Employee)
               .Include(x => x.WorkerAbsens)
               .Include(x => x.Employee.CompanyWorkPlaces)
               .Include(x => x.Employee.CompanyWorkPlaces)
               .Include(x => x.WorkerBonus)
               .Include(x => x.Store)
               .Include(x => x.Vacations)
               .Where(x => x.Working == true).ToListAsync();
            ViewBag.TotalCount = workers.Count();

            string k = "";
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            int currentDay = DateTime.Now.Day;

            var empId = await _dbContext.Salaries.Where(x => x.CalculatedDate.Year == year && x.CalculatedDate.Month == month).ToListAsync();
            foreach (var item in empId)
            {
                k += ("//" + item.EmployeeId + "//");
            }

            SalaryModel salaryModel = new SalaryModel();
            salaryModel.AvialableWorkers = workers.Where(x => !k.Contains("/" + x.EmployeeId + "/") && x.Working==true).Select(x => new AvialableWorker
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

                OldCalculate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),

                Bonus = _dbContext.WorkerBonus.Where(y => y.WorkerId == x.Id && y.BonusDate.Year == year && y.BonusDate.Month == month).Sum(y => y.BonusSalary)
                       + _dbContext.CompanyWorkPlaceBonus.Include(m => m.CompanyWorkPlace)
                          .Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId && y.CompanyWorkPlace.ChangedDate.Year == year && y.CompanyWorkPlace.ChangedDate.Month == month).Select(y => y.BonusSalary).FirstOrDefault(),

                MonthlySalary =x.Position.Salary / daysInMonth * currentDay,

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

            }).Take(5).ToList();

            return View(salaryModel);
        }

        [HttpGet]
        [Authorize(Roles = SD.PayrollSpecalist)]
        public IActionResult CalculateSalary(string selectedDate)
        {
            ViewBag.SkipCount = 5;
            if (selectedDate == null)
            {
                return NotFound();
            }
            var date = Convert.ToDateTime(selectedDate);
            var workers = _dbContext.Users.Where(x=>x.Working==true).ToList();
            string k = "";
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            var empId = _dbContext.Salaries.Where(x => x.CalculatedDate.Year == date.Year && x.CalculatedDate.Month == date.Month).ToList();

            foreach (var item in empId)
            {
                k += ("//" + item.EmployeeId + "//");
            }

            SalaryModel salaryModel = new SalaryModel();

            salaryModel.AvialableWorkers = workers.Where(x => !k.Contains("/" + x.EmployeeId + "/") && x.Working==true).Select(x => new AvialableWorker
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

            }).Take(5).ToList();
            ViewBag.TotalCount = salaryModel.AvialableWorkers.Count();
            return View(salaryModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = SD.PayrollSpecalist)]
        public async Task<IActionResult> CalculateSalary(SalaryModel salaryModel)
        {
            List<Salary> salary = new List<Salary>();
            List<SalaryForApi> salaryForApis = new List<SalaryForApi>();

            foreach (var item in salaryModel.AvialableWorkers)
            {
                if (item.IsChecked == true)
                {
                    salary.Add(new Salary() { EmployeeId = item.EmployeeId, TotalSalary = item.TotalSalary, CalculatedDate = item.OldCalculate });
                    salaryForApis.Add(new SalaryForApi() { IDCardNumber = item.IDCardNumber, Balance = item.TotalSalary });
                }
            }

            using (HttpClient httpClient = new HttpClient())
            {
                string jsonString = JsonConvert.SerializeObject(salaryForApis);
                var requestUrl = new Uri("https://localhost:44399/api/salary?salary=" + jsonString);

                using (HttpContent httpContent = new StringContent(jsonString))
                {
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    HttpResponseMessage response = httpClient.PutAsync(requestUrl, httpContent).Result;
                }
            }
            _dbContext.Salaries.AddRange(salary);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(WorkerSalary));
        }
    }
}