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
    public class StoreController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        public StoreController(HRPayrollDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult AddStore()
        {
            StoreViewModel storeViewModel = new StoreViewModel();
            storeViewModel.Companies = _dbContext.Companies.ToList();
            return View(storeViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddStore(StoreViewModel storeViewModel)
        {

            if (!ModelState.IsValid || storeViewModel.SelectedCompany==0)
            {
                storeViewModel.Companies = _dbContext.Companies.ToList();
                return View(storeViewModel);
            }
            Store store = new Store();

            store.CompanyId = storeViewModel.SelectedCompany;
            store.Name = storeViewModel.Name;
            _dbContext.Stores.Add(store);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(StoreList));
        }

        [HttpGet]
        public async Task<IActionResult> StoreList()
        {

            var stores =await _dbContext.Stores.Select(x => new StoreViewModel
            {
                ID=x.ID,
                Name = x.Name,
                Company=x.Company
                
            }).ToListAsync();

            return View(stores);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var store = _dbContext.Stores.Find(id);

            StoreViewModel storeViewModel = new StoreViewModel();
            storeViewModel.Name = store.Name;
            storeViewModel.Companies = _dbContext.Companies.ToList();
            storeViewModel.CompanyName = store.Company.Name;
            storeViewModel.ID = id;

            return View(storeViewModel);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Edit(int id, StoreViewModel storeViewModel)
        {
            var store = _dbContext.Stores.Find(id);

            if (!ModelState.IsValid)
            {
                storeViewModel.Companies = _dbContext.Companies.ToList();
                storeViewModel.CompanyName = store.Company.Name;
                return View(storeViewModel);
            }

            store.Name = storeViewModel.Name;
            store.CompanyId = storeViewModel.SelectedCompany;
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(StoreList));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var store = _dbContext.Stores.Find(id);

            _dbContext.Stores.Remove(store);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(StoreList));
        }

        
    }
}