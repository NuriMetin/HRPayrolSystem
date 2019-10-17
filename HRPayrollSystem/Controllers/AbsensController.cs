using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRPayrollSystem.DAL;
using HRPayrollSystem.Models;
using HRPayrollSystem.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRPayrollSystem.Controllers
{
    [Authorize]
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
            if (id == null)
            {
                return NotFound();
            }
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
            
            var lastAbsens = await _dbContext.WorkerAbsens.Where(x => x.WorkerId == workers.Id && x.AbsensId == 2 && x.Date.Year == DateTime.Now.Year && x.Date.Month == DateTime.Now.Month).LastOrDefaultAsync();
            int dateCount = 0;

            if (lastAbsens!=null)
            {
                dateCount = DateTime.Now.Day - lastAbsens.Date.Day;
            }

            if (!ModelState.IsValid)
            {
                addAbsens.WorkerAccount = workers.Account;
                addAbsens.WorkerId = workers.Id;
                addAbsens.Absens = _dbContext.Absens.ToList();
                return View(addAbsens);
            }

            WorkerAbsens workerAbsens = new WorkerAbsens();

            workerAbsens.WorkerId = workers.Id;
            workerAbsens.AbsensId = addAbsens.SelectedAbsens;
            workerAbsens.Date = DateTime.Now;
            workerAbsens.Reason = addAbsens.Reason;

            if (dateCount == 1)
            {  
                workerAbsens.AbsensCount = lastAbsens.AbsensCount + 1;
            }
            else
            {
                workerAbsens.AbsensCount = 1;
            }

            await _dbContext.WorkerAbsens.AddAsync(workerAbsens);
            await _dbContext.SaveChangesAsync();

            if (lastAbsens != null)
            {
                if (lastAbsens.AbsensCount == 4 && dateCount == 1)
                {
                    workers.Working = false;
                    await _dbContext.SaveChangesAsync();
                }
            }

            return RedirectToAction("WorkerList", "Worker");
        }

        
    }
}