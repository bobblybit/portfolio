using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    interface IProjectRepository
    {
        Project GetProjectById(int id);
        bool DeleteProjects(int id);
        bool UpdateProjects(int id);
    }
}
