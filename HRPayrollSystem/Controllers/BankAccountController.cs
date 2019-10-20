using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using HRPayrollSystem.DAL;
using HRPayrollSystem.Models;
using HRPayrollSystem.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HRPayrollSystem.Controllers
{
    [Authorize]
    public class BankAccountController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        private readonly UserManager<Worker> _userManager;
        public BankAccountController(HRPayrollDbContext dbContext, UserManager<Worker> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        public async Task<IActionResult> WorkerList()
        {
            
            string k = "";
            var count =  _dbContext.Users
                .Include(x => x.Employee)
                .Include(x => x.Position)
                .Include(x => x.Position.Department)
                .Include(x => x.Store)
                .Where(x => !k.Contains("/" + x.Employee.IDCardNumber + "/") && x.Working == true).Count();

            ViewBag.TotalCount = count;
            ViewBag.SkipCount = 8;

            var data = new List<Account>();
            List<Account> account = new List<Account>();
            using (HttpClient httpClient = new HttpClient())
            {
                var requestUrl = new Uri("https://localhost:44399/api/user");
                HttpResponseMessage response = httpClient.GetAsync(requestUrl).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                account = JsonConvert.DeserializeObject<List<Account>>(result);
            }

            foreach (var item in account)
            {
                k += ("//" + item.IDCardNumber + "//");
            }

            data =await _dbContext.Users
                .Include(x => x.Employee)
                .Include(x => x.Position)
                .Include(x => x.Position.Department)
                .Include(x=>x.Store)
                .Where(x => !k.Contains("/" + x.Employee.IDCardNumber + "/") && x.Working==true).Select(x => new Account
            {
                Department = x.Position.Department.Name,
                Name = x.Employee.Name,
                Position = x.Position.Name,
                IDCardNumber = x.Employee.IDCardNumber,
                IDcardFincode = x.Employee.IDCardFinCode,
                Surname = x.Employee.Surname,
                FatherName = x.Employee.FatherName,
                WorkerId = x.Id,
                StoreName=x.Store.Name
            }).Take(8).ToListAsync();
           

            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> AddAccount(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var worker = await _dbContext.Users.Include(x => x.Employee).Where(x => x.Id == id).Select(x => new Account
            {
                Name = x.Employee.Name,
                Surname = x.Employee.Surname,
                Email = x.Email,
                IDCardNumber = x.Employee.IDCardNumber,
                Number = x.Employee.Number,
                IDcardFincode = x.Employee.IDCardFinCode
            }).ToListAsync();

            using (HttpClient httpClient = new HttpClient())
            {
                string jsonString = JsonConvert.SerializeObject(worker);
                var requestUrl = new Uri("https://localhost:44399/api/User?user=" + jsonString);

                using (HttpContent httpContent = new StringContent(jsonString))
                {
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    HttpResponseMessage response = httpClient.PostAsync(requestUrl, httpContent).Result;
                }
            }
            return RedirectToAction(nameof(WorkerList));
        }
    }
}