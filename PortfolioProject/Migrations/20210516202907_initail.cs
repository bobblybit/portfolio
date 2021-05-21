using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioProject.Migrations
{
    public partial class initail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "proficiencies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proficiencies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    firstName = table.Column<string>(type: "TEXT", nullable: true),
                    lastName = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    aboutInfo = table.Column<string>(type: "TEXT", nullable: true),
                    profilePictureUrl = table.Column<string>(type: "TEXT", nullable: true),
                    twitterUrl = table.Column<string>(type: "TEXT", nullable: true),
                    gitUrl = table.Column<string>(type: "TEXT", nullable: true),
                    cvUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    userID = table.Column<int>(type: "INTEGER", nullable: false),
                    projectTitle = table.Column<string>(type: "TEXT", nullable: true),
                    projectImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    projectDescription = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_projects_user_userID",
                        column: x => x.userID,
                        principalTable: "user",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "proficiencies",
                columns: new[] { "ID", "description", "name" },
                values: new object[] { 1, "Html", "HTML" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "ID", "Phone", "aboutInfo", "cvUrl", "email", "firstName", "gitUrl", "lastName", "profilePictureUrl", "twitterUrl" },
                values: new object[] { 1, "08036142253", "this is me", "https://drive.google.com/file/d/1_SXwWUlIGkkug8G-cs7-ROmfxtNkE7hl/view?usp=sharing", "youngsolomon072@gmail.com", "Young", "https://github.com/bobblybit", "Solomon", "https://res.cloudinary.com/decagom/image/upload/v1621192597/FaceApp_1611401857576_2_bim7ey.jpg", "https://twitter.com/home?lang=en" });

            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "ID", "projectDescription", "projectImageUrl", "projectTitle", "userID" },
                values: new object[] { 1, "simple bank app", "https://res.cloudinary.com/decagom/image/upload/v1621193621/porfolio/2021-05-11_8_s13r6d.png", "Desktop Bank Application", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_projects_userID",
                table: "projects",
                column: "userID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "proficiencies");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
