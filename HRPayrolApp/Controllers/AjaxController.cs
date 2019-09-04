using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRPayrolApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRPayrolApp.Controllers
{
    public class AjaxController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        public AjaxController(HRPayrollDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult LoadPositions(int? departmentId)
        {

            if (departmentId == null)
            {
                return NotFound();
            }

            var data = _dbContext.Positions.Where(m => m.DepartmentId == departmentId);

            if (data == null)
            {
                return NotFound();
            }

            return PartialView("_LoadPositionsPartial", data);
        }
    }
}