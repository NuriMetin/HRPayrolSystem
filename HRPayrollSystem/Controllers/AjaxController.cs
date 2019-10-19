using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HRPayrollSystem.DAL;
using HRPayrollSystem.Models;
using HRPayrollSystem.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HRPayrollSystem.Controllers
{
    public class AjaxController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        private readonly UserManager<Worker> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AjaxController(UserManager<Worker> userManager, HRPayrollDbContext dbContext, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult LoadPositions(int? departmentId)
        {

            if (departmentId == null)
            {
                return NotFound();
            }

            var data = _dbContext.Positions.Where(m => m.DepartmentId == departmentId);

            if (data == null)
            {
                return NotFound();
            }

            return PartialView("_LoadPositionsPartial", data);
        }

        public IActionResult LoadAbsens(int? absensId)
        {
            return NotFound();
        }

        public IActionResult LoadEmployee(int skip)
        {

            var data = _dbContext.Employees.Select(x => new EmployeeViewModel
            {
                ID = x.ID,
                Born = x.Born,
                DistrictRegistration = x.DistrictRegistration,
                EducationText = _dbContext.Educations.Where(m => m.EducationId == x.EducationId).Select(m => m.EducationName).FirstOrDefault(),
                FatherName = x.FatherName,
                GenderText = _dbContext.Genders.Where(m => m.GenderId == x.GenderId).Select(m => m.GenderName).FirstOrDefault(),
                MaritalStatusText = _dbContext.MaritalStatuses.Where(m => m.MaritalStatusId == x.MaritalStatusId).Select(m => m.MaritalStatusName).FirstOrDefault(),
                Name = x.Name,
                IDCardNumber = x.IDCardNumber,
                IDCardFinCode = x.IDCardFinCode,
                Residence = x.Residence,
                Surname = x.Surname,
                Image = x.Image
            }).Skip(skip).Take(2).ToList();

            return View(data);
        }

        public async Task<IActionResult> LoadWorkers(int skip)
        {
            var workers = await _dbContext.Users
                .Include(x => x.Employee)
                .Include(x => x.Position)
                .Include(x => x.Position.Department)
                .Include(x => x.Store)
                .Where(x => x.Working == true).Select(x => new WorkersViewModel
                {
                    WorkerId = x.Id,
                    Email = x.Email,
                    Name = x.Employee.Name,
                    Surname = x.Employee.Surname,
                    Position = x.Position.Name,
                    Department = x.Position.Department.Name,
                    BeginDate = x.BeginDate,
                    StoreName = x.Store.Name,
                    RoleName = _roleManager.Roles.Where(m => m.Id == _dbContext.UserRoles.Where(l => l.UserId == x.Id).Select(l => l.RoleId).FirstOrDefault()).Select(m => m.Name).FirstOrDefault()
                }).Skip(skip).Take(2).ToListAsync();

            return View(workers);
        }

        public IActionResult LoadSalary(int skip)
        {
            var workers = _dbContext.Users.ToList();
            string k = "";
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            int currentDay = DateTime.Now.Day;

            var empId = _dbContext.Salaries.Where(x => x.CalculatedDate.Year == year && x.CalculatedDate.Month == month).ToList();
            foreach (var item in empId)
            {
                k += ("//" + item.EmployeeId + "//");
            }

            SalaryModel salaryModel = new SalaryModel();
            salaryModel.AvialableWorkers = workers.Where(x => !k.Contains("/" + x.EmployeeId + "/")).Select(x => new AvialableWorker
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

            }).Skip(skip).Take(2).ToList();

            return View(salaryModel);
        }

        public IActionResult LoadBankAccount(int skip)
        {
            List<Account> account = new List<Account>();
            using (HttpClient httpClient = new HttpClient())
            {
                // string jsonString = JsonConvert.SerializeObject();
                var requestUrl = new Uri("https://localhost:44399/api/user");
                HttpResponseMessage response = httpClient.GetAsync(requestUrl).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                account = JsonConvert.DeserializeObject<List<Account>>(result);
            }

            string k = "";

            foreach (var item in account)
            {
                k += ("//" + item.IDCardNumber + "//");
            }
            var data = _dbContext.Users.Include(x => x.Employee).Include(x => x.Position).Include(x => x.Position.Department).Where(x => !k.Contains("/" + x.Employee.IDCardNumber + "/")).Select(x => new Account
            {
                Department = x.Position.Department.Name,
                Name = x.Employee.Name,
                Position = x.Position.Name,
                IDCardNumber = x.Employee.IDCardNumber,
                IDcardFincode = x.Employee.IDCardFinCode,
                Surname = x.Employee.Surname,
                FatherName = x.Employee.FatherName,
                WorkerId = x.Id
            }).Skip(skip).Take(2).ToList();

            return View(data);
        }

        public IActionResult LoadStoreBonus(string selectedDate,int skip)
        {
            DateTime date = Convert.ToDateTime(selectedDate);
            SaleViewModel saleViewModel = new SaleViewModel();

            saleViewModel.AvialableStores = _dbContext.Stores.Select(y => new AvialableStores
            {
                SaleSalary = _dbContext.Sales.Where(x => x.Date.Year == date.Year && x.Date.Month == date.Month && x.StoreId == y.ID).Sum(x => x.SaleSalary),
                StoreName = y.Name,
                SelectedDate = date,
                StoreId = y.ID
            }).Skip(skip).Take(2).ToList();

            return View(saleViewModel);
        }

        public async Task<IActionResult> LoadBonusWorkerList(int skip)
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
                              }).Skip(skip).Take(2).ToListAsync();

            return View(data);
        }

        public async Task<IActionResult> LoadDepartmentList(int skip)
        {

            var departments = await _dbContext.Departments.Select(x => new DepartmentViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Company = x.Company

            }).Skip(skip).Take(2).ToListAsync();

            return View(departments);
        }


        public IActionResult LoadCalculateSalary(string selectedDate,int skip)
        {
            if (selectedDate == null)
            {
                return NotFound();
            }
            var date = Convert.ToDateTime(selectedDate);
            var workers = _dbContext.Users.ToList();
            string k = "";
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            var empId = _dbContext.Salaries.Where(x => x.CalculatedDate.Year == date.Year && x.CalculatedDate.Month == date.Month).ToList();

            foreach (var item in empId)
            {
                k += ("//" + item.EmployeeId + "//");
            }

            SalaryModel salaryModel = new SalaryModel();

            salaryModel.AvialableWorkers = workers.Where(x => !k.Contains("/" + x.EmployeeId + "/")).Select(x => new AvialableWorker
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

            }).Skip(skip).Take(2).ToList();

            return View(salaryModel);
        }


       
    }
}