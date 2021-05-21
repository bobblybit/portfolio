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

        public PortFolioDBContext (DbContextOptions<PortFolioDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new User
            {
                ID = 1,
                firstName = "young",
                lastName = "solomon",
                aboutInfo = "this is me",
                twitterUrl = "https://twitter.com/home?lang=en",
                email = "youngsolomon072@gmail.com",
                gitUrl = "https://github.com/bobblybit",
                Phone = "08036142253",
                profilePictureUrl = "",
                cvUrl = "https://drive.google.com/file/d/1_SXwWUlIGkkug8G-cs7-ROmfxtNkE7hl/view?usp=sharing"
            }); ;
        }




    }
}
