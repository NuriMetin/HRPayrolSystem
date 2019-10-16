using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRPayrollSystem.DAL;
using HRPayrollSystem.Models;
using HRPayrollSystem.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HRPayrollSystem.Controllers
{
    public class VacationController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        private readonly UserManager<Worker> _userManager;
        public VacationController(HRPayrollDbContext dbContext, UserManager<Worker> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task<IActionResult> AddVacation(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var worker = await _userManager.FindByIdAsync(id);

            VacationViewModel vacationView = new VacationViewModel();
            vacationView.WorkerId = worker.Id;
            vacationView.WorkerAccount = worker.Account;
            return View(vacationView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddVacation(string id, VacationViewModel vacationView)
        {
            var worker = await _userManager.FindByIdAsync(id);

            if (!ModelState.IsValid)
            {
                vacationView.WorkerAccount = worker.Account;
                vacationView.WorkerId = worker.Id;
                return View(vacationView);
            }

            Vacation vacation = new Vacation();

            vacation.WorkerId = worker.Id;
            vacation.StartDate = vacationView.StartDate;
            vacation.EndDate = vacationView.EndDate;

            await _dbContext.Vacations.AddAsync(vacation);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("WorkerList", "Worker");
        }
    }
}