using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    public class ProjectRepository : IProjectRepository
    {

        private readonly PortFolioDBContext _portfolioDBContext;

        public ProjectRepository(PortFolioDBContext portFolioDBContext)
        {
            _portfolioDBContext = portFolioDBContext;
        }

        public bool AddProject()
        {
            throw new NotImplementedException();
        }

        public bool DeleteProjects(int id)
        {
            throw new NotImplementedException();
        }

        public Project GetProjectById(int Id)
        {
            return _portfolioDBContext.projects.FirstOrDefault(x => x.ID == Id);
        }

        public bool UpdateProjects(int id)
        {
            throw new NotImplementedException();
        }
    }
}
