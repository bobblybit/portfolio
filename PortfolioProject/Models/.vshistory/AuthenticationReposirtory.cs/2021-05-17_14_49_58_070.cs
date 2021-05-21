using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    public class AuthenticationReposirtory
    {
        private readonly PortFolioDBContext _portfolioDBContext;

        public AuthenticationReposirtory(PortFolioDBContext portFolioDBContext)
        {
            _portfolioDBContext = portFolioDBContext;
        }
        //public User getUserByenmaiL(string userEmail)
        //{

        //    //return _portfolioDBContext.user.Where(x => x.email == userEmail).Where().FirstOrDefault();
        //}
    }
}
