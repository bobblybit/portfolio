using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Models;
using PortfolioProject.Services.Interface;
using PortfolioProject.ViewModels;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace PortfolioProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthRepository _IAuthRepository;

        public AccountController( IAuthRepository authRepository)
        {
            _IAuthRepository = authRepository;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            User LoggedInUser = _IAuthRepository.getUser(model.email, model.password);
            if (LoggedInUser == null)
            {
                ViewData["message"] = "User Don't exist";
                return View();
            }
            HttpContext.Session.SetString("loginSession", JsonConvert.SerializeObject(LoggedInUser));
            return RedirectToAction("Dashboard");
        }

        public IActionResult Dashboard()
        {
            var student = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("loginSession"));
            if (HttpContext.Session == null)
            {
                RedirectToAction("Login");
            }
            return View();
        }




    }
}
