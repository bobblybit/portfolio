using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    interface IUserRepository
    {
        User GetUserById();
    }
}
