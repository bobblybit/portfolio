using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Models;
using PortfolioProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _UserRepository;
        private readonly IProficiencyRepository _proficiencyRepository;

        public HomeController(IUserRepository userRepository , IProficiencyRepository proficiencyRepository)
        {
            _UserRepository = userRepository;
            _proficiencyRepository = proficiencyRepository;

        }



        public IActionResult Index()
        {
            var data = _UserRepository.GetUser();
            var proficiency = _proficiencyRepository.GetProficiency();

            HomeViewModel model = new HomeViewModel();

            model.firstName = data.firstName;
            model.lastName = data.lastName;
            model.profilePictureUrl = data.profilePictureUrl;
            model.tagLine = data.tagLine;
            model.aboutInfo = data.aboutInfo;
            model.projects = data.projects;
            model.Proficiency = proficiency;


            return View(model);
        }

        public IActionResult Contact()
        {
            return View(_UserRepository.GetUser());
        }
    }
}
