using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Services.Interface;
using PortfolioProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthRepository _IAuthRepository;


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
             User LoggedInUser =
            return View();
        }
    }
}
