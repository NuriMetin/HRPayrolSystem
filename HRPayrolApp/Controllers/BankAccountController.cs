using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using HRPayrolApp.DAL;
using HRPayrolApp.Models;
using HRPayrolApp.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HRPayrolApp.Controllers
{
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
            List<Account> account = new List<Account>();
            using (HttpClient httpClient = new HttpClient())
            {
                // string jsonString = JsonConvert.SerializeObject();
                var requestUrl = new Uri("http://localhost:53756/api/user");
                HttpResponseMessage response = httpClient.GetAsync(requestUrl).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                account = JsonConvert.DeserializeObject<List<Account>>(result);
            }         

            string k = "";

            foreach (var item in account)
            {
                k += ("//" + item.IDCardNumber + "//");
            }
            var data = _dbContext.Users.Include(x => x.Employee).Include(x => x.Position).Include(x => x.Position.Department).Where(x=>!k.Contains("/"+x.Employee.IDCardNumber+"/")).Select(x => new Account
            {
                Department = x.Position.Department.Name,
                Name = x.Employee.Name,
                Position = x.Position.Name,
                IDCardNumber = x.Employee.IDCardNumber,
                IDcardFincode=x.Employee.IDCardFinCode,
                Surname = x.Employee.Surname,
                FatherName=x.Employee.FatherName,
                WorkerId = x.Id
            }).ToList();

            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> AddAccount(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var worker = await _dbContext.Users.Include(x=>x.Employee).Where(x => x.Id == id).Select(x => new Account
            {
                Name = x.Employee.Name,
                Surname = x.Employee.Surname,
                Email = x.Email,
                IDCardNumber = x.Employee.IDCardNumber,
                Number=x.Employee.Number,
                 IDcardFincode=x.Employee.IDCardFinCode
            }).ToListAsync();

            using (HttpClient httpClient = new HttpClient())
            {
                string jsonString = JsonConvert.SerializeObject(worker);
                var requestUrl = new Uri("http://localhost:53756/api/User?user=" + jsonString);

                using (HttpContent httpContent = new StringContent(jsonString))
                {
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    HttpResponseMessage response = httpClient.PostAsync(requestUrl, httpContent).Result;
                }
            }
            return  RedirectToAction(nameof(WorkerList));
        }
    }
}