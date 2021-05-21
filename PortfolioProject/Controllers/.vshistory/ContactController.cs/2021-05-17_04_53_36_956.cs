using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly IUserRepository _UserRepository;

        public ContactController(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }



        public IActionResult Index()
        {

            return View(_UserRepository.GetUser());
        }
    }
}
