using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Models;
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
                return View();

            return View();
        }
    }
}
