using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRPayrolApp.Models;
using HRPayrolApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRPayrolApp.DAL;

namespace HRPayrolApp.Controllers
{
    public class CompanyController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        public CompanyController(HRPayrollDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult AddCompany()
        { 
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddCompany(Company company)
        {
            if (!ModelState.IsValid)
            {
                return View(company);
            }

            _dbContext.Companies.Add(company);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(CompanyList));
        }

        public async Task<IActionResult> CompanyList()
        { 
            var companies =await _dbContext.Companies.ToListAsync();

            if (companies == null)
            {
                return RedirectToAction(nameof(AddCompany));
            }
            return View(companies);
        }

        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var company = _dbContext.Companies.Find(id);
            if (id == 0)
            {
                return NotFound();
            }
            return View(company);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Company companyModel)
        {
            var company = _dbContext.Companies.Find(id);

            if (!ModelState.IsValid)
            {
                return View(companyModel);
            }

            company.Name = companyModel.Name;
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(CompanyList));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var company = _dbContext.Companies.Find(id);
            _dbContext.Companies.Remove(company);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(CompanyList));
        }
    }
}