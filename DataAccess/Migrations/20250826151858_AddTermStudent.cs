using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddTermStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TermId",
                table: "Students",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_TermId",
                table: "Students",
                column: "TermId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Terms_TermId",
                table: "Students",
                column: "TermId",
                principalTable: "Terms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Terms_TermId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_TermId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TermId",
                table: "Students");
        }
    }
}
