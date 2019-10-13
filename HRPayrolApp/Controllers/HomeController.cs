using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRPayrolApp.Models;
using Microsoft.AspNetCore.Identity;
using static HRPayrolApp.Models.SD;
using HRPayrolApp.DAL;

namespace HRPayrolApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        private readonly UserManager<Worker> _userManager;
        private readonly SignInManager<Worker> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public HomeController(HRPayrollDbContext dbContext, UserManager<Worker> userManager, SignInManager<Worker> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public async Task MyRolesAddedAction()
        {
            if(!await _roleManager.RoleExistsAsync(Roles.Admin.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            }
            if (!await _roleManager.RoleExistsAsync(Roles.HR.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.HR.ToString()));
            }
            if(!await _roleManager.RoleExistsAsync(Roles.DepartmentHead.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.DepartmentHead.ToString()));
            }
            if(!await _roleManager.RoleExistsAsync(Roles.PayrollSpecalist.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.PayrollSpecalist.ToString()));
            }
            if(!await _roleManager.RoleExistsAsync(Roles.PayrollSpecalist.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.PayrollSpecalist.ToString()));
            }
            if(!await _roleManager.RoleExistsAsync(Roles.Worker.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.Worker.ToString()));
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Login()
        {

            return RedirectToAction();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
