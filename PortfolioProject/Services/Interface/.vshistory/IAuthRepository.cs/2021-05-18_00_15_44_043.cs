using PortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Services.Interface
{
    public interface IAuthRepository
    {
        User getUserByEmaiL(string userEmail , string password);
    }
}
