using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRPayrolApp.Models;
using Microsoft.AspNetCore.Mvc;
using HRPayrolApp.DAL;
using HRPayrolApp.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace HRPayrolApp.Controllers
{
    public class AjaxController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        public AjaxController(HRPayrollDbContext dbContext)
        {
            _dbContext = dbContext;
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

            var data =  _dbContext.Employees.Select(x => new EmployeeViewModel
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
                IDCardFinCode=x.IDCardFinCode,
                Residence = x.Residence,
                Surname = x.Surname,
                Image = x.Image
            }).Skip(skip).Take(2).ToList();

            return View(data);
        }

        public IActionResult LoadSalary(int skip)
        {
            var workers =  _dbContext.Users.ToList();
            string k = "";
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            int currentDay = DateTime.Now.Day;

            var empId =  _dbContext.Salaries.Where(x => x.CalculatedDate.Year == year && x.CalculatedDate.Month == month).ToList();
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
    }
}