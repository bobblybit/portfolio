using Microsoft.EntityFrameworkCore;
using PortfolioProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly PortFolioDBContext _portfolioDBContext ;

        public UserRepository(PortFolioDBContext portFolioDBContext)
        {
            _portfolioDBContext = portFolioDBContext;
        }

        public User GetUser()
        {
            return _portfolioDBContext.user.Include(x => x.projects).FirstOrDefault();

        }

        public List<Proficiency> GetProficiency()
        {
            return _portfolioDBContext.proficiencies.ToList();

        }

        public bool UpdateUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
