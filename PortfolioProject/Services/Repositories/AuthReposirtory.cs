using PortfolioProject.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    public class AuthReposirtory : IAuthRepository
    {
        private readonly PortFolioDBContext _portfolioDBContext;

        public AuthReposirtory(PortFolioDBContext portFolioDBContext)
        {
            _portfolioDBContext = portFolioDBContext;
        }

        public User getUser(string userEmail , string password)
        {
            return _portfolioDBContext.user.Where(x => x.email == userEmail).Where(x => x.loginPassword == password).FirstOrDefault();
        }

    }
}
