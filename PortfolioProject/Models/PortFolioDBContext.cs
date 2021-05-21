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
                firstName = "Young",
                lastName = "Solomon",
                aboutInfo = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "           Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                "            when an unknown printer took a galley of type and scrambled it to make a type specimen book. " +
                "           It has survived not only five centuries, but also the leap into electronic typesetting, remaining " +
                "           essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",

                twitterUrl = "https://twitter.com/home?lang=en",
                email = "youngsolomon072@gmail.com",
                gitUrl = "https://github.com/bobblybit",
                Phone = "08036142253",
                profilePictureUrl = "https://res.cloudinary.com/decagom/image/upload/v1621192597/FaceApp_1611401857576_2_bim7ey.jpg",
                cvUrl = "https://drive.google.com/file/d/1_SXwWUlIGkkug8G-cs7-ROmfxtNkE7hl/view?usp=sharing",
                loginPassword = "12345",
                tagLine = "Lets build something great together"
            });

            modelBuilder.Entity<Project>().HasData(
            new Project { ID = 1, userID = 1, projectTitle = "Desktop Bank Application", projectDescription = "simple bank app", projectImageUrl = "https://res.cloudinary.com/decagom/image/upload/v1621193621/porfolio/2021-05-11_8_s13r6d.png" },
            new Project { ID = 2, userID = 1, projectTitle = "GP Calculator Console Application", projectDescription = "Application Calculates Student GP", projectImageUrl = "https://res.cloudinary.com/decagom/image/upload/v1621454499/porfolio/2021-05-19_6_bwwd7g.png" });

            modelBuilder.Entity<Proficiency>().HasData(
                new Proficiency {ID = 1, name = "HTML",description="HTML",},
                new Proficiency { ID = 2, name = "CSS", description = "CSS", },
                new Proficiency { ID = 3, name = "BootStrap", description = "BootStrap", },
                new Proficiency { ID = 4, name = "JavaScript", description = "JavaScript", },
                new Proficiency { ID = 5, name = "C#", description = "C#", },
                new Proficiency { ID = 6, name = "PHP", description = "PHP", });
        }




    }
}
