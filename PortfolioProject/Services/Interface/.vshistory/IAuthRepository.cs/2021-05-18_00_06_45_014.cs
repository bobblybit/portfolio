using PortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Services.Interface
{
    interface IAuthRepository
    {
        User getUserByenmaiL(string userEmail);
    }
}
