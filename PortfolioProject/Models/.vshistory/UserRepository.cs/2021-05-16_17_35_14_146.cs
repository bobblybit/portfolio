using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    public class UserRepository : IUserRepository
    {
        public User GetUserById(int Id)
        {
           // return _PortfolioDbContext.users.FirstOrDefault(x => x.ID == Id);
        }

        public bool UpdateUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
