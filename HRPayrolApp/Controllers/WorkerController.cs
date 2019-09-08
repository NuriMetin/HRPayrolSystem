using System;
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

namespace HRPayrolApp.Controllers
{
   // [Authorize]
    public class WorkerController : Controller
    {
       
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
                create.Employees = _dbContext.Employees.ToList();
                create.Departments = _dbContext.Departments.ToList();
                return View(create);
            }
            create.Password = $"{Path.GetRandomFileName().ToUpper()}_{Path.GetRandomFileName().ToLower()}_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm")}";

            Worker worker = new Worker
            {
                Email = create.Email,
                EmployeeId = create.SelectedEmployee,
                PositionId = create.SelectedPosition,
                UserName=create.Email,
                Account =_dbContext.Employees.Where(x=>x.ID==create.SelectedEmployee).Select(x=>x.Name).FirstOrDefault() +" "+ _dbContext.Employees.Where(x => x.ID == create.SelectedEmployee).Select(x => x.Surname).FirstOrDefault(),
                PassText=create.Password,
                BeginDate=create.BeginDate
            };
            
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
            //var abCount = await _dbContext.ExcusableAbsens.Where(m=>m.ID==).CountAsync();

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


            //var data = await _userManager.Users.Select(m => new WorkersViewModel
            //{
            //    EmployeName = m.Employee.Name,
            //    EmployeSurname = m.Employee.Surname,
            //    Dismiss = m.WorkerDismisses.Select(x => x.Dismiss).ToList()
            //}).ToListAsync();
            //return View();
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

            var wb = await _dbContext.WorkerBonus.Where(w => w.WorkerId == id).ToListAsync();
            var wa = await _dbContext.WorkerAbsens.Where(w => w.WorkerId == id).ToListAsync();

            var workerBonus = await _dbContext.WorkerBonus.Where(w => w.WorkerId == id).FirstOrDefaultAsync();

            workersView.Departments = _dbContext.Departments.ToList();
            workersView.Employees = _dbContext.Employees.ToList();
            workersView.Name = _dbContext.Employees.Where(x => x.ID == workers.EmployeeId).Select(x => x.Name).FirstOrDefault();
            workersView.Surname = _dbContext.Employees.Where(x => x.ID == workers.EmployeeId).Select(x => x.Surname).FirstOrDefault();
            workersView.Position = _dbContext.Positions.Where(x => x.ID == workers.PositionId).Select(x => x.Name).FirstOrDefault();
            workersView.Email = workers.Email;
            workersView.Department = _dbContext.Positions.Include(m => m.Department).Where(x => x.ID == workers.PositionId).Select(m => m.Department.Name).FirstOrDefault();
            workersView.Password = workers.PassText;

           var positionId = await _dbContext.Positions.Where(x => x.ID == workers.PositionId).Select(x => x.ID).FirstOrDefaultAsync();

            //var WorkerBonusId = await _dbContext.WorkerBonus.Where(x => x.WorkerId == workers.Id).Select(x => x.ID).FirstOrDefaultAsync();
            //var workerBonus = await _dbContext.WorkerBonus.FindAsync(WorkerBonusId);

            string companyWorkPlaceId = $"{Path.GetRandomFileName()}_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm")}";
            string companyWorkPlaceBonusId= $"{Path.GetRandomFileName().ToLower()}_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm")}";
            if (!ModelState.IsValid)
            {
                return View(workersView);
            }

            if(workersView.SelectedPosition == positionId)
            {
                return View(workersView);
            }

            CompanyWorkPlace companyWorkPlace = new CompanyWorkPlace
            {
                ID = companyWorkPlaceId,
                EmployeeId = workers.EmployeeId,
                ChangedDate = DateTime.Now,
                PositionId = positionId
            };

            CompanyWorkPlaceBonus companyWorkPlaceBonus = new CompanyWorkPlaceBonus
            {
                ID = companyWorkPlaceBonusId,
                CompanyWorkPlaceId = companyWorkPlaceId,
                BonusSalary =await _dbContext.WorkerBonus.Where(x=>x.WorkerId==workers.Id).Select(x=>x.BonusSalary).SumAsync(),
            };
            CompanyWorkPlaceAbsens companyWorkPlaceAbsens = new CompanyWorkPlaceAbsens
            {
                CompanyWorkPlaceId = companyWorkPlaceId,
                Date = DateTime.Now,
                ExcusableAbsens = await _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 1).CountAsync(),
                UnExcusableAbsens = await _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 2).CountAsync()
            };

            _dbContext.CompanyWorkPlaces.Add(companyWorkPlace);

            _dbContext.CompanyWorkPlaceBonus.Add(companyWorkPlaceBonus);

            _dbContext.CompanyWorkPlaceAbsens.Add(companyWorkPlaceAbsens);

            _dbContext.WorkerBonus.RemoveRange(wb);
            _dbContext.WorkerAbsens.RemoveRange(wa);
            await _dbContext.SaveChangesAsync();

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
         
            await _userManager.DeleteAsync(workers);
            
            IdentityResult result = await _userManager.CreateAsync(worker, workersView.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

           await _userManager.AddToRoleAsync(worker, Roles.Worker.ToString());

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
                BonusDate = addBonus.BonusDate,
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
               
                 WorkerAccount=workers.Account,
                  WorkerId=workers.Id,
                   Absens=_dbContext.Absens.ToList()
                  
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
                Date = addAbsens.Date,
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
            //var user = await _userManager.Users.FindAsync(id)
            var worker = await _userManager.FindByIdAsync(id);
            if (worker != null)
            {
                await _userManager.DeleteAsync(worker);
                return RedirectToAction(nameof(WorkerList));
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> CalculateSalary(string id)
        {
            var workers =await _userManager.FindByIdAsync(id);

            Salary salary = new Salary
            {
                WorkerId = workers.Id,
                WorkerAccount = workers.Account,
                MonthlySalary = _dbContext.Positions.Where(x => x.ID == workers.PositionId).Select(x => x.Salary).FirstOrDefault(),
                Bonus = Convert.ToDecimal(await _dbContext.WorkerBonus.Where(x => x.WorkerId == workers.Id).Select(x => x.BonusSalary).SumAsync())
                    + Convert.ToDecimal(_dbContext.CompanyWorkPlaceBonus.Where(x => x.CompanyWorkPlace.EmployeeId == workers.EmployeeId).Select(x => x.BonusSalary).FirstOrDefault()),
                ExcusableAbsens = await _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 1).CountAsync(),
                UnExcusableAbsens = await _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 2).CountAsync(),
                AbsensCount = await _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 1).CountAsync()
                       + await _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 2).CountAsync()
                        + _dbContext.CompanyWorkPlaceAbsens.Include(m => m.CompanyWorkPlace).Where(m => m.CompanyWorkPlace.EmployeeId == workers.EmployeeId).Select(x => x.UnExcusableAbsens).Sum()
                            + _dbContext.CompanyWorkPlaceAbsens.Include(m => m.CompanyWorkPlace).Where(m => m.CompanyWorkPlace.EmployeeId == workers.EmployeeId).Select(x => x.ExcusableAbsens).Sum(),

                TotalSalary = (_dbContext.Positions.Where(x => x.ID == workers.PositionId).Select(x => x.Salary).FirstOrDefault()) / (
                       await _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 2).CountAsync()
                        + _dbContext.CompanyWorkPlaceAbsens.Include(m => m.CompanyWorkPlace).Where(m => m.CompanyWorkPlace.EmployeeId == workers.EmployeeId).Select(x => x.UnExcusableAbsens).Sum()
                            + _dbContext.CompanyWorkPlaceAbsens.Include(m => m.CompanyWorkPlace).Where(m => m.CompanyWorkPlace.EmployeeId == workers.EmployeeId).Select(x => x.ExcusableAbsens).Sum())
                            + Convert.ToDecimal(await _dbContext.WorkerBonus.Where(x => x.WorkerId == workers.Id).Select(x => x.BonusSalary).SumAsync())

            };

            return View(salary);
        }

        public async Task<IActionResult> WorkerSalary(string id)
        {
            var workers = await _userManager.FindByIdAsync(id);

            Salary salary = new Salary
            {
                WorkerId = workers.Id,
                WorkerAccount = workers.Account,
                MonthlySalary = _dbContext.Positions.Where(x => x.ID == workers.PositionId).Select(x => x.Salary).FirstOrDefault(),
                Bonus = Convert.ToDecimal(await _dbContext.WorkerBonus.Where(x => x.WorkerId == workers.Id).Select(x => x.BonusSalary).SumAsync())
                    + Convert.ToDecimal(_dbContext.CompanyWorkPlaceBonus.Where(x => x.CompanyWorkPlace.EmployeeId == workers.EmployeeId).Select(x => x.BonusSalary).FirstOrDefault()),
                ExcusableAbsens = await _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 1).CountAsync(),
                UnExcusableAbsens = await _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 2).CountAsync(),
                AbsensCount = await _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 1).CountAsync()
                       + await _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 2).CountAsync()
                        + _dbContext.CompanyWorkPlaceAbsens.Include(m => m.CompanyWorkPlace).Where(m => m.CompanyWorkPlace.EmployeeId == workers.EmployeeId).Select(x => x.UnExcusableAbsens).Sum()
                            + _dbContext.CompanyWorkPlaceAbsens.Include(m => m.CompanyWorkPlace).Where(m => m.CompanyWorkPlace.EmployeeId == workers.EmployeeId).Select(x => x.ExcusableAbsens).Sum(),

                TotalSalary = (_dbContext.Positions.Where(x => x.ID == workers.PositionId).Select(x => x.Salary).FirstOrDefault()) / (
                       await _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 2).CountAsync()
                        + _dbContext.CompanyWorkPlaceAbsens.Include(m => m.CompanyWorkPlace).Where(m => m.CompanyWorkPlace.EmployeeId == workers.EmployeeId).Select(x => x.UnExcusableAbsens).Sum()
                            + _dbContext.CompanyWorkPlaceAbsens.Include(m => m.CompanyWorkPlace).Where(m => m.CompanyWorkPlace.EmployeeId == workers.EmployeeId).Select(x => x.ExcusableAbsens).Sum())
                            + Convert.ToDecimal(await _dbContext.WorkerBonus.Where(x => x.WorkerId == workers.Id).Select(x => x.BonusSalary).SumAsync())

            };
            return View(salary);
        }
    }
}