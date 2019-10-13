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
    public class PositionController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        public PositionController(HRPayrollDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult AddPosition()
        {
            PositionViewModel positionViewModel = new PositionViewModel();
            positionViewModel.Departments = _dbContext.Departments.ToList();
            return View(positionViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddPosition(PositionViewModel positionViewModel)
        {

            if (!ModelState.IsValid || positionViewModel.SelectedDepartment == 0)
            {
                positionViewModel.Departments = _dbContext.Departments.ToList();
                return View(positionViewModel);
            }
            Position position = new Position();

            position.DepartmentId = positionViewModel.SelectedDepartment;
            position.Name = positionViewModel.Name;
            position.Salary = positionViewModel.Salary;
            _dbContext.Positions.Add(position);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(PositionList));
        }

        [HttpGet]
        public async Task<IActionResult> PositionList()
        {

            var positions = await _dbContext.Positions.Select(x => new PositionViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Department = x.Department,
                Salary=x.Salary

            }).ToListAsync();

            return View(positions);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var position = _dbContext.Positions.Find(id);

            PositionViewModel positionViewModel = new PositionViewModel();
            positionViewModel.Name = position.Name;
            positionViewModel.Departments = _dbContext.Departments.ToList();
            positionViewModel.DepartmentName = position.Department.Name;
            positionViewModel.Salary = position.Salary;
            positionViewModel.ID = id;

            return View(positionViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(int id, PositionViewModel positionViewModel)
        {
            var position = _dbContext.Positions.Find(id);

            if (!ModelState.IsValid)
            {
                positionViewModel.Departments = _dbContext.Departments.ToList();
                positionViewModel.DepartmentName = position.Department.Name;
                positionViewModel.Salary = position.Salary;
                return View(positionViewModel);
            }

            position.Name = positionViewModel.Name;
            position.DepartmentId = positionViewModel.SelectedDepartment;
            position.Salary = positionViewModel.Salary;
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(PositionList));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var position = _dbContext.Positions.Find(id);

            _dbContext.Positions.Remove(position);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(PositionList));
        }
    }
}