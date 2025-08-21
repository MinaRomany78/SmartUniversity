using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TermAndSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Term",
                table: "UniversityCourses");

            migrationBuilder.AddColumn<int>(
                name: "TermId",
                table: "UniversityCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TermNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "General" },
                    { 2, "Computer Science" },
                    { 3, "Information Systems" }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "TermNumber", "Year" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 1, 2 },
                    { 4, 2, 2 },
                    { 5, 1, 3 },
                    { 6, 2, 3 },
                    { 7, 1, 4 },
                    { 8, 2, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UniversityCourses_TermId",
                table: "UniversityCourses",
                column: "TermId");

            migrationBuilder.AddForeignKey(
                name: "FK_UniversityCourses_Terms_TermId",
                table: "UniversityCourses",
                column: "TermId",
                principalTable: "Terms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UniversityCourses_Terms_TermId",
                table: "UniversityCourses");

            migrationBuilder.DropTable(
                name: "Terms");

            migrationBuilder.DropIndex(
                name: "IX_UniversityCourses_TermId",
                table: "UniversityCourses");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "TermId",
                table: "UniversityCourses");

            migrationBuilder.AddColumn<string>(
                name: "Term",
                table: "UniversityCourses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
