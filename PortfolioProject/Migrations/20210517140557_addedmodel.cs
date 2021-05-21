using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioProject.Migrations
{
    public partial class addedmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "loginPassword",
                table: "user",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tagLine",
                table: "user",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "loginPassword", "tagLine" },
                values: new object[] { "12345", "Lets build something great together" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "loginPassword",
                table: "user");

            migrationBuilder.DropColumn(
                name: "tagLine",
                table: "user");
        }
    }
}
