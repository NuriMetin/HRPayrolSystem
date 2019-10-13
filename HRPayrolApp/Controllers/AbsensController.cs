using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRPayrolApp.Models;
using HRPayrolApp.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using HRPayrolApp.DAL;
using Microsoft.AspNetCore.Mvc;

namespace HRPayrolApp.Controllers
{
    public class AbsensController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        private readonly UserManager<Worker> _userManager;

        public AbsensController(HRPayrollDbContext dbContext, UserManager<Worker> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
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

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAbsens(string id, AddAbsens addAbsens)
        {
            var workers = await _userManager.FindByIdAsync(id);

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

            return RedirectToAction("WorkerList/Worker");
        }
    }
}