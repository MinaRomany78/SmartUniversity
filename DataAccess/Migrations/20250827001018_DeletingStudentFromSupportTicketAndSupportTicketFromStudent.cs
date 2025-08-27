using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DeletingStudentFromSupportTicketAndSupportTicketFromStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupportTickets_Students_StudentId",
                table: "SupportTickets");

            migrationBuilder.DropIndex(
                name: "IX_SupportTickets_StudentId",
                table: "SupportTickets");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "SupportTickets");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "SupportTickets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupportTickets_StudentId",
                table: "SupportTickets",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupportTickets_Students_StudentId",
                table: "SupportTickets",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }
    }
}
