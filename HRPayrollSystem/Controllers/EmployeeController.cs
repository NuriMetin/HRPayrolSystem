using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HRPayrollSystem.DAL;
using HRPayrollSystem.Extensions;
using HRPayrollSystem.Models;
using HRPayrollSystem.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using static HRPayrollSystem.Utilities.Utilities;

namespace HRPayrollSystem.Controllers
{
    // [Authorize(Roles = SD.HR)]
    public class EmployeeController : Controller
    {
        private readonly UserManager<Worker> _userManager;
        private readonly HRPayrollDbContext _dbContext;
        private readonly IHostingEnvironment _env;
        public EmployeeController(HRPayrollDbContext dbContext, IHostingEnvironment env, UserManager<Worker> userManager)
        {
            _dbContext = dbContext;
            _env = env;
            _userManager = userManager;
        }

        public IActionResult Create()
        {
            var createEmployee = new EmployeeViewModel
            {
                Genders = _dbContext.Genders.ToList(),
                Educations = _dbContext.Educations.ToList(),
                Maritals = _dbContext.MaritalStatuses.ToList()
            };

            return View(createEmployee);
        }


        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeViewModel create, Employee employee)
        {
            create.Genders = _dbContext.Genders.ToList();
            create.Maritals = _dbContext.MaritalStatuses.ToList();
            create.Educations = _dbContext.Educations.ToList();

            string imgName = $"{Path.GetRandomFileName().ToUpper()}_{Path.GetRandomFileName().ToLower()}_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm")}.jpeg";

            if (!ModelState.IsValid)
            {
                return View(create);
            }

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View(create);
            }

            if (!create.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "File type must be image");
                return View(create);
            }

            employee.Image = await employee.Photo.SaveAsync(_env.WebRootPath);

            employee.Name = create.Name;
            employee.Surname = create.Surname;
            employee.FatherName = create.FatherName;
            employee.Born = create.Born;
            employee.Residence = create.Residence;
            employee.IDCardNumber = create.IDCardNumber;
            employee.IDCardFinCode = create.IDCardFinCode;
            employee.DistrictRegistration = create.DistrictRegistration;
            employee.EducationId = create.SelectedEducation;
            employee.GenderId = create.SelectedGender;
            employee.MaritalStatusId = create.SelectedMarital;
            employee.Number = create.Number;

            await _dbContext.Employees.AddAsync(employee);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(EmployeeList));
        }

        [HttpGet]
        public async Task<IActionResult> AddWorkPlace(int id)
        {
            var employe = await _dbContext.Employees.FindAsync(id);
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddWorkPlace(Employee employee)
        {

            return View();
        }

        [HttpGet]
        public IActionResult EmployeeList()
        {
            ViewBag.TotalCount = _dbContext.Employees.Count();
            ViewBag.SkipCount = 4;
            var data = _dbContext.Employees.Select(x => new EmployeeViewModel
            {
                ID = x.ID,
                EducationText = _dbContext.Educations.Where(m => m.EducationId == x.EducationId).Select(m => m.EducationName).FirstOrDefault(),
                FatherName = x.FatherName,
                Name = x.Name,
                Surname = x.Surname,
                Image = x.Image
            }).Take(4).ToList();

            return View(data);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var emp = await _dbContext.Employees.FindAsync(id);

            EmployeeViewModel employee = new EmployeeViewModel
            {

                Name = emp.Name,
                Surname = emp.Surname,
                FatherName = emp.FatherName,
                Born = emp.Born,
                DistrictRegistration = emp.DistrictRegistration,
                GenderText = _dbContext.Genders.Where(k => k.GenderId == emp.GenderId).Select(k => k.GenderName).FirstOrDefault(),
                EducationText = _dbContext.Educations.Where(k => k.EducationId == emp.EducationId).Select(k => k.EducationName).FirstOrDefault(),
                MaritalStatusText = _dbContext.MaritalStatuses.Where(k => k.MaritalStatusId == emp.MaritalStatusId).Select(k => k.MaritalStatusName).FirstOrDefault(),
                IDCardNumber = emp.IDCardNumber,
                Residence = emp.Residence,
                Educations = _dbContext.Educations.ToList(),
                Genders = _dbContext.Genders.ToList(),
                Maritals = _dbContext.MaritalStatuses.ToList(),
                Image = emp.Image,
                IDCardFinCode = emp.IDCardFinCode,
                Number = emp.Number
            };

            if (employee == null)
            {
                return BadRequest();
            }

            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EmployeeViewModel empViewModel)
        {
            empViewModel.Genders = _dbContext.Genders.ToList();
            empViewModel.Maritals = _dbContext.MaritalStatuses.ToList();
            empViewModel.Educations = _dbContext.Educations.ToList();
            if (!ModelState.IsValid)
            {
                return View(empViewModel);
            }
            var employee = await _dbContext.Employees.FindAsync(id);

            if (empViewModel.Photo != null)
            {
                ModelState.AddModelError("Photo", "File type must be image");
                if (!empViewModel.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "File type must be image");
                    return View(empViewModel);
                }

                RemoveImage(_env.WebRootPath, employee.Image);
                employee.Image = await empViewModel.Photo.SaveAsync(_env.WebRootPath);

            }

            employee.Name = empViewModel.Name;
            employee.Surname = empViewModel.Surname;
            employee.FatherName = empViewModel.FatherName;
            employee.Residence = empViewModel.Residence;
            employee.DistrictRegistration = empViewModel.DistrictRegistration;
            employee.IDCardFinCode = empViewModel.IDCardFinCode;
            employee.IDCardNumber = empViewModel.IDCardNumber;
            employee.EducationId = empViewModel.SelectedEducation;
            employee.GenderId = empViewModel.SelectedGender;
            employee.MaritalStatusId = empViewModel.SelectedMarital;
            employee.Born = empViewModel.Born;
            employee.Number = empViewModel.Number;
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(EmployeeList));

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            var employee = await _dbContext.Employees.FindAsync(id);
            var workerId = await _dbContext.Users.Where(x => x.EmployeeId == id).Select(x => x.Id).FirstOrDefaultAsync();

            var companyWorkPlaceAbsens = _dbContext.CompanyWorkPlaceAbsens.Where(x => x.CompanyWorkPlace.EmployeeId == employee.ID).ToList();
            var companyWorkPlaceBonus = _dbContext.CompanyWorkPlaceBonus.Where(x => x.CompanyWorkPlace.EmployeeId == employee.ID).ToList();
            var companyWorkPlace = _dbContext.CompanyWorkPlaces.Where(x => x.EmployeeId == employee.ID).ToList();
            var workerBonus = _dbContext.WorkerBonus.Where(x => x.WorkerId == workerId).ToList();
            var workerAbsens = _dbContext.WorkerAbsens.Where(x => x.WorkerId == workerId).ToList();
            var worker = await _userManager.FindByIdAsync(workerId);

            if (employee != null)
            {
                _dbContext.CompanyWorkPlaceAbsens.RemoveRange(companyWorkPlaceAbsens);
                _dbContext.CompanyWorkPlaceBonus.RemoveRange(companyWorkPlaceBonus);
                _dbContext.CompanyWorkPlaces.RemoveRange(companyWorkPlace);
                _dbContext.WorkerBonus.RemoveRange(workerBonus);
                _dbContext.WorkerAbsens.RemoveRange(workerAbsens);

                RemoveImage(_env.WebRootPath, employee.Image);

                if (worker != null)
                    await _userManager.DeleteAsync(worker);

                _dbContext.Employees.Remove(employee);

                _dbContext.SaveChanges();
                return RedirectToAction(nameof(EmployeeList));
            }
            return BadRequest();
        }
    }
}