using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRPayrolApp.Models;
using HRPayrolApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRPayrolApp.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        public DepartmentController(HRPayrollDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult AddDepartment()
        {
            DepartmentViewModel departmentViewModel = new DepartmentViewModel();
            departmentViewModel.Companies = _dbContext.Companies.ToList();
            return View(departmentViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddDepartment(DepartmentViewModel departmentViewModel)
        {

            if (!ModelState.IsValid || departmentViewModel.SelectedCompany == 0)
            {
                departmentViewModel.Companies = _dbContext.Companies.ToList();
                return View(departmentViewModel);
            }
            Department department = new Department();

            department.CompanyId = departmentViewModel.SelectedCompany;
            department.Name = departmentViewModel.Name;
            _dbContext.Departments.Add(department);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(DepartmentList));
        }

        [HttpGet]
        public async Task<IActionResult> DepartmentList()
        {

            var departments = await _dbContext.Departments.Select(x => new DepartmentViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Company = x.Company

            }).ToListAsync();

            return View(departments);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = _dbContext.Departments.Find(id);

            DepartmentViewModel departmentViewModel = new DepartmentViewModel();
            departmentViewModel.Name = department.Name;
            departmentViewModel.Companies = _dbContext.Companies.ToList();
            departmentViewModel.CompanyName = department.Company.Name;
            departmentViewModel.ID = id;

            return View(departmentViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(int id, DepartmentViewModel departmentViewModel)
        {
            var department = _dbContext.Departments.Find(id);

            if (!ModelState.IsValid)
            {
                departmentViewModel.Companies = _dbContext.Companies.ToList();
                departmentViewModel.CompanyName = department.Company.Name;
                return View(departmentViewModel);
            }

            department.Name = departmentViewModel.Name;
            department.CompanyId = departmentViewModel.SelectedCompany;
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(DepartmentList));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var department = _dbContext.Departments.Find(id);

            _dbContext.Departments.Remove(department);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(DepartmentList));
        }
    }
}