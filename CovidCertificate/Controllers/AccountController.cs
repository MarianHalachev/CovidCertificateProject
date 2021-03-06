using CovidCertificate.Data.Models;
using CovidCertificate.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidCertificate.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        public IActionResult Register()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            
            var user = new User
            {
                UserName = model.Username,
                Email = model.Email,
                
                
            };
            var result = this.userManager.CreateAsync(user, model.Password).Result;
            if (result.Succeeded)
            {
                if (this.userManager.Users.Count() == 1)
                {
                    var roleResult = this.signInManager.UserManager.AddToRoleAsync(user, "Admin").Result;
                    if (roleResult.Errors.Any())
                    {
                        return this.View();
                    }
                }
                else
                {
                    var roleResult = this.signInManager.UserManager.AddToRoleAsync(user, "User").Result;
                    if (roleResult.Errors.Any())
                    {
                        return this.View();
                    }
                }

                return this.RedirectToAction("Index", "Home");
            }

            this.signInManager.SignInAsync(user, isPersistent: false);
            return this.View();
        }
        public IActionResult Login()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var user = this.userManager.Users.FirstOrDefault(u => u.UserName == model.UserName);
            var result = this.signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, lockoutOnFailure: true).Result;
            if (result.Succeeded)
            {
                return this.RedirectToAction("Index", "Home");
            }

            return this.View();
        }
        public IActionResult Logout()
        {
            this.signInManager.SignOutAsync();
            return this.RedirectToAction("Index", "Home");
        }
    }
}
