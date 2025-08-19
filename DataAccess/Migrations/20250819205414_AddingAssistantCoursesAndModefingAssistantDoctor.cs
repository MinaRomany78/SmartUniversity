using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddingAssistantCoursesAndModefingAssistantDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AssistantCourses",
                columns: table => new
                {
                    AssistantId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssistantCourses", x => new { x.AssistantId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_AssistantCourses_Assistants_AssistantId",
                        column: x => x.AssistantId,
                        principalTable: "Assistants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AssistantCourses_UniversityCourses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "UniversityCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorAssistants_CourseId",
                table: "DoctorAssistants",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_AssistantCourses_CourseId",
                table: "AssistantCourses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorAssistants_UniversityCourses_CourseId",
                table: "DoctorAssistants",
                column: "CourseId",
                principalTable: "UniversityCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorAssistants_UniversityCourses_CourseId",
                table: "DoctorAssistants");

            migrationBuilder.DropTable(
                name: "AssistantCourses");

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
    }
}
