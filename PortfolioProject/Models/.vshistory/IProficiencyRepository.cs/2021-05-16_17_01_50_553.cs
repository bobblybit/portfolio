using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    interface IProficiencyRepository
    {
        bool AddProficiency();
        Proficiency GetProficiencyById(int id);
        bool UpdateProficiency(int id);
        bool DeleteProficiency(int id);
    }
}
