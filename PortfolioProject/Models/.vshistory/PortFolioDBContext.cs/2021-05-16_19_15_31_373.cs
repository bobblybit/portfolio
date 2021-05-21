using Microsoft.EntityFrameworkCore;
using PortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject
{
    public class PortFolioDBContext:DbContext
    {
        public DbSet<User> user { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Proficiency> proficiencies { get; set; }
    }
}
