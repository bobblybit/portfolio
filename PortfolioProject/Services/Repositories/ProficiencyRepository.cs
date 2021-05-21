using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    public class ProficiencyRepository : IProficiencyRepository
    {
        private readonly PortFolioDBContext _portfolioDBContext;

        public ProficiencyRepository(PortFolioDBContext portFolioDBContext)
        {
            _portfolioDBContext = portFolioDBContext;
        }


        public bool AddProficiency()
        {
            throw new NotImplementedException();
        }

        public bool DeleteProficiency(int id)
        {
            throw new NotImplementedException();
        }

        public Proficiency GetProficiencyById(int Id)
        {
            return _portfolioDBContext.proficiencies.FirstOrDefault(x => x.ID == Id);
        }

        public List<Proficiency> GetProficiency()
        {
            return _portfolioDBContext.proficiencies.ToList();

        }
        public bool UpdateProficiency(int id)
        {
            throw new NotImplementedException();
        }
    }
}
