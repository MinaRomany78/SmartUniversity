using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ModifingOnSupportTicketModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupportTickets_Students_StudentID",
                table: "SupportTickets");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "SupportTickets",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_SupportTickets_StudentID",
                table: "SupportTickets",
                newName: "IX_SupportTickets_StudentId");

            migrationBuilder.AddColumn<string>(
                name: "AdminResponse",
                table: "SupportTickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SupportTickets_Students_StudentId",
                table: "SupportTickets",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupportTickets_Students_StudentId",
                table: "SupportTickets");

            migrationBuilder.DropColumn(
                name: "AdminResponse",
                table: "SupportTickets");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "SupportTickets",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_SupportTickets_StudentId",
                table: "SupportTickets",
                newName: "IX_SupportTickets_StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_SupportTickets_Students_StudentID",
                table: "SupportTickets",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
