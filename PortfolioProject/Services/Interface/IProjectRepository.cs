using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    interface IProjectRepository
    {
        bool AddProject();
        Project GetProjectById(int Id);
        bool DeleteProjects(int id);
        bool UpdateProjects(int id);
    }
}
