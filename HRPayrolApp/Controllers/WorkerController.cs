﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using HRPayrolApp.Models;
using HRPayrolApp.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using static HRPayrolApp.Models.SD;
using Microsoft.AspNetCore.Hosting;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using HRPayrolApp.Helper;
using System.Net.Http;
using Newtonsoft.Json;
using RestSharp;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using NUnit.Framework;

namespace HRPayrolApp.Controllers
{
   // [Authorize]
    public class WorkerController : Controller
    {
        BankApi _api = new BankApi();
        private readonly HRPayrollDbContext _dbContext;
        private readonly UserManager<Worker> _userManager;
        private readonly SignInManager<Worker> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public WorkerController(IHostingEnvironment env,HRPayrollDbContext dbContext, UserManager<Worker> userManager, SignInManager<Worker> signInManager, RoleManager<IdentityRole> roleManager)
        {
            
            _dbContext = dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

       // [Authorize(Roles = SD.PayrollSpecalist)]
        public IActionResult Create()
        {
            WorkersViewModel workerModel = new WorkersViewModel
            {
                Stores = _dbContext.Stores.ToList(),
                Departments = _dbContext.Departments.ToList(),
                Employees = _dbContext.Employees.ToList(),
            };
            return View(workerModel);
        }

       // [Authorize(Roles = SD.PayrollSpecalist)]
        [HttpPost,ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(WorkersViewModel create)
        {
            if (!ModelState.IsValid)
            {
                create.Stores = _dbContext.Stores.ToList();
                create.Employees = _dbContext.Employees.ToList();
                create.Departments = _dbContext.Departments.ToList();
                return View(create);
            }
            Worker worker = new Worker();

            if (create.SelectedStore == 0)
            {
                worker.StoreId = null;
            }

            worker.StoreId = create.SelectedStore;
            create.Password = $"{Path.GetRandomFileName().ToUpper()}_{Path.GetRandomFileName().ToLower()}_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm")}";

            worker.Email = create.Email;
            worker.EmployeeId = create.SelectedEmployee;
            worker.PositionId = create.SelectedPosition;
            worker.UserName = create.Email;
            worker.Account = _dbContext.Employees.Where(x => x.ID == create.SelectedEmployee).Select(x => x.Name).FirstOrDefault() + " " + _dbContext.Employees.Where(x => x.ID == create.SelectedEmployee).Select(x => x.Surname).FirstOrDefault();
            worker.PassText = create.Password;
            worker.BeginDate = create.BeginDate;
            

            IdentityResult result = await _userManager.CreateAsync(worker, create.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                create.Employees = _dbContext.Employees.ToList();
                create.Departments = _dbContext.Departments.ToList();
                return View(create);
            }
            await _userManager.AddToRoleAsync(worker, Roles.Worker.ToString());

           // await _signInManager.SignInAsync(worker, false);

            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com",587);
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("nurimetin98@gmail.com","Metin1998*#");
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(worker.Email);
            mailMessage.From = new MailAddress("nurimetin98@gmail.com");

            mailMessage.Subject = "Your password...";
            mailMessage.Body = worker.PassText;
            mailMessage.BodyEncoding = UTF8Encoding.UTF8;
            client.Send(mailMessage);
            mailMessage.IsBodyHtml = true;

            return RedirectToAction(nameof(WorkerList));
        }

     //   [Authorize(Roles = "PayrollSpecalist,HR")]
        public async Task<IActionResult> WorkerList()
        {
            var data = await (from work in _userManager.Users
                              join emp in _dbContext.Employees
                              on work.EmployeeId equals emp.ID
                              join pos in _dbContext.Positions
                              on work.PositionId equals pos.ID
                              join dep in _dbContext.Departments
                              on pos.DepartmentId equals dep.ID
                              select new WorkersViewModel
                              {
                                  WorkerId = work.Id,
                                  Email = work.Email,
                                  Name = emp.Name,
                                  Surname = emp.Surname,
                                  Position = pos.Name,
                                  Department = dep.Name,
                                  BeginDate=work.BeginDate
                              }).ToListAsync();

            return View(data);
        }

        public async Task<IActionResult> WorkerBonus()
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

        //  [Authorize(Roles = SD.PayrollSpecalist)]
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var worker = await _userManager.FindByIdAsync(id);
            WorkersViewModel workersView = new WorkersViewModel
            {
                Departments = _dbContext.Departments.ToList(),
                Employees = _dbContext.Employees.ToList(),
                Name = _dbContext.Employees.Where(x => x.ID == worker.EmployeeId).Select(x => x.Name).FirstOrDefault(),
                Surname = _dbContext.Employees.Where(x => x.ID == worker.EmployeeId).Select(x => x.Surname).FirstOrDefault(),
                Position = _dbContext.Positions.Where(x => x.ID == worker.PositionId).Select(x => x.Name).FirstOrDefault(),
                Email=worker.Email,
                Department = _dbContext.Positions.Include(m=>m.Department).Where(x=>x.ID==worker.PositionId).Select(m=>m.Department.Name).FirstOrDefault()
            };

            return View(workersView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, WorkersViewModel workersView)
        {
            var workers = await _userManager.FindByIdAsync(id);

            string companyWorkPlaceId = $"{Path.GetRandomFileName()}_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm")}";
            string companyWorkPlaceBonusId = $"{Path.GetRandomFileName().ToLower()}_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm")}";
            string companyWorkPlaceAbsensId = $"{Path.GetRandomFileName().ToUpper()}_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm")}";

            workersView.Departments = _dbContext.Departments.ToList();
            workersView.Employees = _dbContext.Employees.ToList();
            workersView.Name = _dbContext.Employees.Where(x => x.ID == workers.EmployeeId).Select(x => x.Name).FirstOrDefault();
            workersView.Surname = _dbContext.Employees.Where(x => x.ID == workers.EmployeeId).Select(x => x.Surname).FirstOrDefault();
            workersView.Position = _dbContext.Positions.Where(x => x.ID == workers.PositionId).Select(x => x.Name).FirstOrDefault();
            workersView.Email = workers.Email;
            workersView.Department = _dbContext.Positions.Include(m => m.Department).Where(x => x.ID == workers.PositionId).Select(m => m.Department.Name).FirstOrDefault();
            workersView.Password = workers.PassText;

            if (!ModelState.IsValid)
            {
                return View(workersView);
            }

            if (workersView.SelectedPosition == workers.PositionId)
            {
                return View(workersView);
            }

            CompanyWorkPlace companyWorkPlace = new CompanyWorkPlace
            {
                ID= companyWorkPlaceId,
                EmployeeId = workers.EmployeeId,
                ChangedDate = DateTime.Now,
                PositionId = workersView.SelectedPosition
            };

            _dbContext.CompanyWorkPlaces.Add(companyWorkPlace);

            CompanyWorkPlaceBonus companyWorkPlaceBonus = new CompanyWorkPlaceBonus
            {
                ID= companyWorkPlaceBonusId,
                CompanyWorkPlaceId = companyWorkPlaceId,
                BonusSalary = _dbContext.WorkerBonus.Where(x => x.WorkerId == workers.Id).Select(x => x.BonusSalary).Sum()
            };
            _dbContext.CompanyWorkPlaceBonus.Add(companyWorkPlaceBonus);

            CompanyWorkPlaceAbsens companyWorkPlaceAbsens = new CompanyWorkPlaceAbsens
            {
                ID= companyWorkPlaceAbsensId,
                CompanyWorkPlaceId = companyWorkPlaceId,
                ExcusableAbsens = _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 1).Count(),
                UnExcusableAbsens = _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 2).Count()
            };
            _dbContext.CompanyWorkPlaceAbsens.Add(companyWorkPlaceAbsens);

            Worker worker = new Worker
            {
                BeginDate = DateTime.Now,
                Account = workers.Account,
                Email = workers.Email,
                EmployeeId = workers.EmployeeId,
                PassText = workers.PassText,
                UserName = workers.UserName,
                PositionId = workersView.SelectedPosition
            };

            _dbContext.WorkerBonus.RemoveRange(_dbContext.WorkerBonus.Where(x => x.WorkerId == workers.Id).ToList());
            _dbContext.WorkerAbsens.RemoveRange(_dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id).ToList());

            await _userManager.DeleteAsync(workers);

            IdentityResult result = await _userManager.CreateAsync(worker, workers.PassText);

            if (!result.Succeeded)
            {
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            await _userManager.AddToRoleAsync(worker, Roles.Worker.ToString());
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(WorkerList));
        }

       // [Authorize(Roles = SD.HR)]
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

        //[Authorize(Roles = SD.HR)]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBonus(string id, AddBonus addBonus)
        {

            var workers = await _userManager.FindByIdAsync(id);

            string bonusId = $"{Path.GetRandomFileName()}_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm")}";

            //if (!ModelState.IsValid)
            //{
            //    return BadRequest();
            //}

            WorkerBonus bonus = new WorkerBonus
            {
                WorkerId=workers.Id,
                BonusSalary = addBonus.BonusSalary,
                BonusDate = DateTime.Now,
                Reason = addBonus.Reason
            };

            _dbContext.WorkerBonus.Add(bonus);
            
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(WorkerList));
        }

        [HttpGet]
        public async Task<IActionResult> AddAbsens(string id)
        {
            var workers = await _userManager.FindByIdAsync(id);

            AddAbsens addAbsens = new AddAbsens
            {
                WorkerAccount = workers.Account,
                WorkerId = workers.Id,
                Absens = _dbContext.Absens.ToList()
            };

            return View(addAbsens);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAbsens(string id, AddAbsens addAbsens)
        {
            var workers =await _userManager.FindByIdAsync(id);

            addAbsens.WorkerAccount = workers.Account;
            addAbsens.WorkerId = workers.Id;
            addAbsens.Absens = _dbContext.Absens.ToList();
            //if (!ModelState.IsValid)
            //{
            //    return View(addAbsens);
            //}

            WorkerAbsens workerAbsens = new WorkerAbsens
            {
                WorkerId = workers.Id,
                AbsensId = addAbsens.SelectedAbsens,
                Date = DateTime.Now,
                Reason = addAbsens.Reason
            };

            await _dbContext.WorkerAbsens.AddAsync(workerAbsens);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(WorkerList));
        }

        // [Authorize(Roles = SD.PayrollSpecalist)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
          
            var worker = await _userManager.FindByIdAsync(id);
            if (worker != null)
            {
                await _userManager.DeleteAsync(worker);
                return RedirectToAction(nameof(WorkerList));
            }

            return BadRequest();
        }

        public async Task<IActionResult> WorkerSalary()
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
                k+=("//"+item.EmployeeId+"//");
            }
           
            SalaryModel salaryModel = new SalaryModel();
            salaryModel.AvialableWorkers = workers.Where(x=>!k.Contains("/"+x.EmployeeId+"/")).Select(x => new AvialableWorker
            {
                Department = _dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Department.Name).FirstOrDefault(),
                ID = x.Id,
                Name = _dbContext.Employees.Where(y => y.Worker.Id == x.Id).Select(y => y.Name).FirstOrDefault(),
                IDCardNumber = _dbContext.Employees.Where(y => y.Worker.Id == x.Id)
                    .Select(y => y.PersonalityCardNumber).FirstOrDefault(),

                Surname = _dbContext.Employees.Where(y => y.Worker.Id == x.Id).Select(y => y.Surname).FirstOrDefault(),
                Position = _dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Name).FirstOrDefault(),
                IsChecked = false,
                EmployeeId = x.EmployeeId,

                OldCalculate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),

                Bonus = _dbContext.WorkerBonus.Where(y => y.WorkerId == x.Id && y.BonusDate.Year == year && y.BonusDate.Month == month).Sum(y => y.BonusSalary)
                 + _dbContext.CompanyWorkPlaceBonus.Include(m => m.CompanyWorkPlace)
                    .Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId && y.CompanyWorkPlace.ChangedDate.Year == year && y.CompanyWorkPlace.ChangedDate.Month == month).Select(y => y.BonusSalary).FirstOrDefault(),

                MonthlySalary = _dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Salary).FirstOrDefault()/daysInMonth*currentDay,

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

                TotalSalary = (_dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Salary).FirstOrDefault()/daysInMonth*currentDay - _dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Salary).FirstOrDefault() / daysInMonth
                         * _dbContext.WorkerAbsens.Where(y => y.AbsensId == 2 && y.WorkerId == x.Id && y.Date.Year == year && y.Date.Month == month).Count()
                            + _dbContext.CompanyWorkPlaceAbsens.Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId && y.CompanyWorkPlace.ChangedDate.Year == year && y.CompanyWorkPlace.ChangedDate.Month == month)
                                .Select(y => y.UnExcusableAbsens).FirstOrDefault())
                                    + _dbContext.WorkerBonus.Where(y => y.WorkerId == x.Id && y.BonusDate.Year == year && y.BonusDate.Month == month).Sum(y => y.BonusSalary)
                 + _dbContext.CompanyWorkPlaceBonus.Include(m => m.CompanyWorkPlace)
                    .Where(y => y.CompanyWorkPlace.EmployeeId == x.EmployeeId && y.CompanyWorkPlace.ChangedDate.Year == year && y.CompanyWorkPlace.ChangedDate.Month == month).Select(y => y.BonusSalary).FirstOrDefault()

            }).ToList();

            return View(salaryModel);
        }


        [HttpPost,ValidateAntiForgeryToken]
        public async Task<IActionResult> WorkerSalary(SalaryModel salaryModel,string selectedDate)
        {
            List<Salary> salary = new List<Salary>();
            List<SalaryForApi> salaryForApis = new List<SalaryForApi>();

            List<WorkersViewModel> workersViewModels = new List<WorkersViewModel>();

            foreach (var item in salaryModel.AvialableWorkers)
            {
                if (item.IsChecked == true && item.OldCalculate != Convert.ToDateTime(selectedDate))
                {   
                     salary.Add(new Salary() { EmployeeId = item.EmployeeId, TotalSalary = item.TotalSalary, CalculatedDate = Convert.ToDateTime(selectedDate) });
                     salaryForApis.Add(new SalaryForApi() { IDCardNumber = item.IDCardNumber, Balance = item.TotalSalary});
                }
            }
       
            using (HttpClient httpClient = new HttpClient())
            {
                string jsonString = JsonConvert.SerializeObject(salaryForApis);
                var requestUrl = new Uri("http://localhost:53756/api/salary?salary=" + jsonString);
                
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

        [HttpGet]
        public IActionResult CalculateSalary(string selectedDate)
        {
            var date = Convert.ToDateTime(selectedDate);
            var workers = _dbContext.Users.ToList();
            string k = "";
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            var empId = _dbContext.Salaries.Where(x => x.CalculatedDate.Year == date.Year && x.CalculatedDate.Month == date.Month).ToList();
            foreach (var item in empId)
            {
                k+=("//"+item.EmployeeId+"//");
            }
           
            SalaryModel salaryModel = new SalaryModel();
            salaryModel.AvialableWorkers = workers.Where(x=>!k.Contains("/"+x.EmployeeId+"/")).Select(x => new AvialableWorker
            {
                Department = _dbContext.Positions.Where(y => y.ID == x.PositionId).Select(y => y.Department.Name).FirstOrDefault(),
                ID = x.Id,
                Name = _dbContext.Employees.Where(y => y.Worker.Id == x.Id).Select(y => y.Name).FirstOrDefault(),
                IDCardNumber = _dbContext.Employees.Where(y => y.Worker.Id == x.Id)
                    .Select(y => y.PersonalityCardNumber).FirstOrDefault(),

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CalculateSalary(SalaryModel salaryModel)
        {
            List<Salary> salary = new List<Salary>();
            List<SalaryForApi> salaryForApis = new List<SalaryForApi>();

            List<WorkersViewModel> workersViewModels = new List<WorkersViewModel>();

            foreach (var item in salaryModel.AvialableWorkers)
            {
                if (item.IsChecked == true )
                {
                    salary.Add(new Salary() { EmployeeId = item.EmployeeId, TotalSalary = item.TotalSalary, CalculatedDate = item.OldCalculate });
                    salaryForApis.Add(new SalaryForApi() { IDCardNumber = item.IDCardNumber, Balance = item.TotalSalary });
                }
            }

            using (HttpClient httpClient = new HttpClient())
            {
                string jsonString = JsonConvert.SerializeObject(salaryForApis);
                var requestUrl = new Uri("http://localhost:53756/api/salary?salary=" + jsonString);

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