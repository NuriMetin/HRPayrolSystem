using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRPayrolApp.DAL;
using Microsoft.AspNetCore.Mvc;
using HRPayrolApp.DAL;

namespace HRPayrolApp.Controllers
{
    public class VacationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}