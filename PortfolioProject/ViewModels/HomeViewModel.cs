using PortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.ViewModels
{
    public class HomeViewModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string tagLine { get; set; }
        public string  aboutInfo { get; set; }
        public string profilePictureUrl { get; set; }
        public IEnumerable<Project> projects { get; set; }
        public IEnumerable<Proficiency> Proficiency { get; set; }

    }
}
