using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRPayrollSystem.DAL;
using HRPayrollSystem.Models;
using HRPayrollSystem.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HRPayrollSystem.Controllers
{
    [Authorize]
    public class SaleController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        public SaleController(HRPayrollDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult AddSale()
        {
            AvialableStores saleView = new AvialableStores();
            saleView.Stores = _dbContext.Stores.ToList();
            return View(saleView);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddSale(AvialableStores stores)
        {
            //if (!ModelState.IsValid)
            //{
            //    saleViewModel.Stores = _dbContext.Stores.ToList();
            //    return View(saleViewModel);
            //}

            Sale sale = new Sale();
            sale.StoreId = stores.StoreId;
            sale.SaleSalary = stores.SaleSalary;
            sale.Date = stores.Date;

            _dbContext.Sales.Add(sale);
            _dbContext.SaveChanges();

            return RedirectToAction("StoreList", "Store");
        }

        public IActionResult StoreSale(string selectedDate)
        {
            if (selectedDate == null)
            {
                return NotFound();
            }
            DateTime date = Convert.ToDateTime(selectedDate);

            var storeSale = _dbContext.Sales.Where(x => x.Date.Year == date.Year && x.Date.Month == date.Month);

            var data = _dbContext.Stores.Select(y => new AvialableStores
            {
                SaleSalary = _dbContext.Sales.Where(x => x.Date.Year == date.Year && x.Date.Month == date.Month && x.StoreId == y.ID).Sum(x => x.SaleSalary),
                StoreName = y.Name,
                SelectedDate = date
            }).ToList();

            List<AvialableStores> sale = new List<AvialableStores>();

            foreach (var item in data)
            {
                sale.Add(new AvialableStores() { StoreName = item.StoreName, SaleSalary = item.SaleSalary, SelectedDate = item.SelectedDate });
            }
            return View(sale);
        }
    }
}