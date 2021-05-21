using Microsoft.EntityFrameworkCore;
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


        public IEnumerable<User> AllUsers
        {
            get
            {
                return _portfolioDBContext.user.Include(x => x.projects);
            }
        }


        public User GetUserById(int Id)
        {
            return _portfolioDBContext.user.FirstOrDefault(x => x.ID == Id);

        }

        public bool UpdateUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
