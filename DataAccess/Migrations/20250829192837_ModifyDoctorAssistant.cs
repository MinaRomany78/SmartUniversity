using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ModifyDoctorAssistant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorAssistants_UniversityCourses_CourseId",
                table: "DoctorAssistants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorAssistants",
                table: "DoctorAssistants");

            migrationBuilder.DropIndex(
                name: "IX_DoctorAssistants_CourseId",
                table: "DoctorAssistants");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "DoctorAssistants");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorAssistants",
                table: "DoctorAssistants",
                columns: new[] { "DoctorId", "AssistantId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorAssistants",
                table: "DoctorAssistants");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "DoctorAssistants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorAssistants",
                table: "DoctorAssistants",
                columns: new[] { "DoctorId", "AssistantId", "CourseId" });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorAssistants_CourseId",
                table: "DoctorAssistants",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorAssistants_UniversityCourses_CourseId",
                table: "DoctorAssistants",
                column: "CourseId",
                principalTable: "UniversityCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
