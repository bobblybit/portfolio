using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _UserRepository;

        public HomeController(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }



        public IActionResult Index()
        {
            return View(_UserRepository.GetUser());
        }
    }
}
