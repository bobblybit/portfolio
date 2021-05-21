using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    public interface IUserRepository
    {
        User GetUser();
        bool UpdateUser(int id);
    }
}
