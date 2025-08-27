using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddingOnSupportTicketModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupportTickets_Students_StudentId",
                table: "SupportTickets");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "SupportTickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "SenderEmail",
                table: "SupportTickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderName",
                table: "SupportTickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SupportTickets_Students_StudentId",
                table: "SupportTickets",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupportTickets_Students_StudentId",
                table: "SupportTickets");

            migrationBuilder.DropColumn(
                name: "SenderEmail",
                table: "SupportTickets");

            migrationBuilder.DropColumn(
                name: "SenderName",
                table: "SupportTickets");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "SupportTickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SupportTickets_Students_StudentId",
                table: "SupportTickets",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
