using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> AllUsers { get; }

        User GetUserById(int Id);
        bool UpdateUser(int id);
    }
}
