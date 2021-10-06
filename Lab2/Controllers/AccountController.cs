using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Lab2.Models;
using Lab2.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class AccountController : Controller
    {

        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        public AccountController(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegistrationModel userRegistrationModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userRegistrationModel);
            }
            var user = mapper.Map<User>(userRegistrationModel);
            user.UserName = userRegistrationModel.Email;
            var result = await userManager.CreateAsync(user, userRegistrationModel.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return View(userRegistrationModel);
            }
            await userManager.AddToRoleAsync(user, "Administrator");
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
        public IActionResult Login(string returnUrl = null)
        {
            ViewBag.url = returnUrl;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginModel userLoginModel, string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return View(userLoginModel);
            }
            var result = await signInManager.PasswordSignInAsync(userLoginModel.Email, userLoginModel.Password, userLoginModel.RememberMe, false);
            if (result.Succeeded)
            {
                return RedirectToLocal(returnUrl);
            }
            else
            {
                ModelState.AddModelError("", "Invalid UserName or Password");
                return View();
            }
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }



    }
}