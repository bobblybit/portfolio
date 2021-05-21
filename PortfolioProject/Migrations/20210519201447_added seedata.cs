using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioProject.Migrations
{
    public partial class addedseedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "loginPassword",
                table: "user",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "user",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "proficiencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "description",
                value: "HTML");

            migrationBuilder.InsertData(
                table: "proficiencies",
                columns: new[] { "ID", "description", "name" },
                values: new object[] { 2, "CSS", "CSS" });

            migrationBuilder.InsertData(
                table: "proficiencies",
                columns: new[] { "ID", "description", "name" },
                values: new object[] { 3, "BootStrap", "BootStrap" });

            migrationBuilder.InsertData(
                table: "proficiencies",
                columns: new[] { "ID", "description", "name" },
                values: new object[] { 4, "JavaScript", "JavaScript" });

            migrationBuilder.InsertData(
                table: "proficiencies",
                columns: new[] { "ID", "description", "name" },
                values: new object[] { 5, "C#", "C#" });

            migrationBuilder.InsertData(
                table: "proficiencies",
                columns: new[] { "ID", "description", "name" },
                values: new object[] { 6, "PHP", "PHP" });

            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "ID", "projectDescription", "projectImageUrl", "projectTitle", "userID" },
                values: new object[] { 2, "Application Calculates Student GP", "https://res.cloudinary.com/decagom/image/upload/v1621454499/porfolio/2021-05-19_6_bwwd7g.png", "GP Calculator Console Application", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "proficiencies",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "proficiencies",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "proficiencies",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "proficiencies",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "proficiencies",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "loginPassword",
                table: "user",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "user",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "proficiencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "description",
                value: "Html");
        }
    }
}
