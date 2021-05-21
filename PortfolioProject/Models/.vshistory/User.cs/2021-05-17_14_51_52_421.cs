using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    public class User
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Phone { get; set; }
        public string email { get; set; }
        public string aboutInfo { get; set; }
        public string profilePictureUrl { get; set; }
        public string twitterUrl { get; set; }
        public string gitUrl { get; set; }
        public string cvUrl { get; set; }
        public IEnumerable<Project> projects { get; set; }
        public string loginPassword { get; set; }
    }
}
