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
using static HRPayrolApp.Models.SD;
using Microsoft.AspNetCore.Hosting;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HRPayrolApp.DAL;

namespace HRPayrolApp.Controllers
{
   // [Authorize]
    public class WorkerController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        private readonly UserManager<Worker> _userManager;
        public WorkerController(IHostingEnvironment env,HRPayrollDbContext dbContext, UserManager<Worker> userManager)
        { 
            _dbContext = dbContext;
            _userManager = userManager;
        }

       // [Authorize(Roles = SD.PayrollSpecalist)]
        public IActionResult Create()
        {
            WorkersViewModel workerModel = new WorkersViewModel
            {
                Stores = _dbContext.Stores.ToList(),
                Departments = _dbContext.Departments.ToList(),
                Employees = _dbContext.Employees.Where(x => x.Worker == null).ToList(),
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
                create.Employees = _dbContext.Employees.Where(x=>x.Worker==null).ToList();
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
            worker.Account = _dbContext.Employees.Where(x => x.ID == create.SelectedEmployee).Select(x => x.Name).FirstOrDefault() + " " 
                                          + _dbContext.Employees.Where(x => x.ID == create.SelectedEmployee).Select(x => x.Surname).FirstOrDefault();
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

            SmtpClient client = new SmtpClient("smtp.gmail.com",587);
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

        //  [Authorize(Roles = SD.PayrollSpecalist)]
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
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
       
    }
}