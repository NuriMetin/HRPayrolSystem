using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using HRPayrollSystem.DAL;
using HRPayrollSystem.Models;
using HRPayrollSystem.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRPayrollSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly HRPayrollDbContext _dbContext;
        private readonly UserManager<Worker> _userManager;
        private readonly SignInManager<Worker> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(HRPayrollDbContext dbContext, UserManager<Worker> userManager, SignInManager<Worker> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult AccessDenied()
        {
            return Content("Role is false");
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var data = await _userManager.FindByEmailAsync(login.Email);

            if (data == null)
            {
                ModelState.AddModelError("", "Email or Password is wrong!!");
                return View(login);
            }

            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(data, login.Password, login.RememberMe, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email or Password is wrong!!");
                return View(login);
            }

            return Redirect("/Home/Index");

        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/Account/Login");
        }


        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(LoginViewModel login)
        {
            var data = await _userManager.FindByEmailAsync(login.Email);

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("nurimetin98@gmail.com", "Metin1998*#");
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(data.Email);
            mailMessage.From = new MailAddress("nurimetin98@gmail.com");

            mailMessage.Subject = "Your password...";
            mailMessage.Body = data.PassText;
            mailMessage.BodyEncoding = UTF8Encoding.UTF8;
            client.Send(mailMessage);
            mailMessage.IsBodyHtml = true;

            return RedirectToAction(nameof(Login));
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordVM changePassword)
        {
            if (!ModelState.IsValid)
            {
                return View(changePassword);
            }
            var user = await _dbContext.Users.Where(x => x.Working == true).SingleOrDefaultAsync(x => _userManager.FindByNameAsync(User.Identity.Name).GetAwaiter().GetResult().Id == x.Id);
            var email = user.Email;
            user.PassText = changePassword.Password;

            IdentityResult result = await _userManager.ChangePasswordAsync(user,changePassword.OldPassword, changePassword.Password);

            return RedirectToAction("Index", "Home");
        }
    }
}