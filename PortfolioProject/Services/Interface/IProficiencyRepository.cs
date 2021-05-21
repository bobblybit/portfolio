using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    public interface IProficiencyRepository
    {
        bool AddProficiency();
        Proficiency GetProficiencyById(int Id);
        bool UpdateProficiency(int id);
        bool DeleteProficiency(int id);
        List<Proficiency> GetProficiency();
    }
}
