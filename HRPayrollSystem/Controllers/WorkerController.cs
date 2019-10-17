using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using HRPayrollSystem.DAL;
using HRPayrollSystem.Models;
using HRPayrollSystem.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static HRPayrollSystem.Models.SD;

namespace HRPayrollSystem.Controllers
{
    [Authorize]
    public class WorkerController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        private readonly UserManager<Worker> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public WorkerController(IHostingEnvironment env, HRPayrollDbContext dbContext, UserManager<Worker> userManager, RoleManager<IdentityRole> roleManagerr)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManagerr;
        }

        //[Authorize(Roles = SD.HR)]
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

        //[Authorize(Roles = SD.HR)]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(WorkersViewModel create)
        {
            if (!ModelState.IsValid)
            {
                create.Stores = _dbContext.Stores.ToList();
                create.Employees = _dbContext.Employees.Where(x => x.Worker == null).ToList();
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
            worker.Working = true;

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

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("nurimetin98@gmail.com", "Metin1998*#");
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

        //[Authorize(Roles = SD.HR)]
        public async Task<IActionResult> WorkerList()
        {
            var workers = await _dbContext.Users.Include(x => x.Employee).Include(x => x.Position).Include(x => x.Position.Department).Where(x => x.Working == true).Select(x => new WorkersViewModel
            {
                WorkerId = x.Id,
                Email = x.Email,
                Name = x.Employee.Name,
                Surname = x.Employee.Surname,
                Position = x.Position.Name,
                Department = x.Position.Department.Name,
                BeginDate = x.BeginDate
            }).ToListAsync();

            return View(workers);
        }

        [Authorize(Roles = SD.HR)]
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
                Email = worker.Email,
                Department = _dbContext.Positions.Include(m => m.Department).Where(x => x.ID == worker.PositionId).Select(m => m.Department.Name).FirstOrDefault()
            };

            return View(workersView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = SD.HR)]
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
                ID = companyWorkPlaceId,
                EmployeeId = workers.EmployeeId,
                ChangedDate = DateTime.Now,
                PositionId = workersView.SelectedPosition
            };

            _dbContext.CompanyWorkPlaces.Add(companyWorkPlace);

            CompanyWorkPlaceBonus companyWorkPlaceBonus = new CompanyWorkPlaceBonus
            {
                ID = companyWorkPlaceBonusId,
                CompanyWorkPlaceId = companyWorkPlaceId,
                BonusSalary = _dbContext.WorkerBonus.Where(x => x.WorkerId == workers.Id).Select(x => x.BonusSalary).Sum()
            };
            _dbContext.CompanyWorkPlaceBonus.Add(companyWorkPlaceBonus);

            CompanyWorkPlaceAbsens companyWorkPlaceAbsens = new CompanyWorkPlaceAbsens
            {
                ID = companyWorkPlaceAbsensId,
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
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            await _userManager.AddToRoleAsync(worker, Roles.Worker.ToString());
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(WorkerList));
        }

        //[Authorize(Roles = SD.HR)]
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

        [Authorize(Roles = "HR,Admin")]
        public async Task<IActionResult> RemovidWorkers()
        {
            var workers = await _dbContext.Users.Include(x=>x.Employee).Include(x=>x.Position).Include(x=>x.Position.Department).Where(x => x.Working == false).Select(x => new WorkersViewModel
            {
                WorkerId = x.Id,
                Email = x.Email,
                Name = x.Employee.Name,
                Surname = x.Employee.Surname,
                Position = x.Position.Name,
                Department = x.Position.Department.Name,
                BeginDate = x.BeginDate
            }).ToListAsync();

            if (workers == null)
            {
                return NoContent();
            }

            return View(workers);
        }

        [HttpPost, ValidateAntiForgeryToken]
        //[Authorize(Roles = "HR,Admin")]
        public IActionResult UndoWorker(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var worker = _dbContext.Users.Find(id);

            if (worker != null)
            {
                worker.Working = true;
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(RemovidWorkers));
            }
            return BadRequest();
        }

        //[Authorize(Roles = SD.Admin)]
        public async Task<IActionResult> ChangeRole()
        {
            var user = await _dbContext.Users.Include(x => x.Employee).Include(x=>x.Position).Include(x=>x.Position.Department).Where(x => x.Working == true)
                .SingleOrDefaultAsync(x => _userManager.FindByNameAsync(User.Identity.Name)
                     .GetAwaiter().GetResult().Id == x.Id);
            var role = _dbContext.UserRoles.Where(x => x.UserId == user.Id).Select(x => x.RoleId).FirstOrDefault();
  
            var roleVM = new RoleVM {
                 Roles=_roleManager.Roles.ToList(),
                  Name=user.Employee.Name,
                   Surname=user.Employee.Surname,
                   WorkerId=user.Id,
                    Position=user.Position.Name,
                     Department=user.Position.Department.Name,
                      RoleName=_roleManager.Roles.Where(x=>x.Id==role).Select(x=>x.Name).FirstOrDefault()
            };
            return View(roleVM);
        }

        //[Authorize(Roles = SD.Admin)]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(RoleVM roleVM)
        {
            var worker = await _userManager.FindByIdAsync(roleVM.WorkerId);

            await _userManager.RemoveFromRolesAsync(worker, await _userManager.GetRolesAsync(worker));

            await _userManager.AddToRoleAsync(worker,(await _roleManager.FindByIdAsync(roleVM.SelectedRole)).Name);



            var dat = roleVM.SelectedRole;
            
            return RedirectToAction(nameof(WorkerList));
        }
    }
}