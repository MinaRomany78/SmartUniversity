using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ModifingOnOptionalCourseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-100",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2fe706ed-1c4e-4624-9f8d-6021a943f923", "6cc03944-38d0-4ff8-aaf2-38ab40dab695" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-101",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6291d7c5-1d97-4f30-a79f-c157239017dc", "d7e29e5e-79b2-48ab-a456-bf3572a07b5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-102",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6a61c663-3292-4499-99c6-23b61c512baf", "0bb5a100-a633-40ff-b409-0acd9e29370b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f6a19369-a2c8-433e-8482-f4e3c74d0b0b", "49ed3a6a-b33d-4183-9d34-a9669c6b7fe5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-104",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a4c5746-c966-431c-b8d0-689b2895a995", "c2d6323c-7787-4151-81c0-1d77fc32de42" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-100",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10d81547-307a-47e1-860c-8221c9942bd9", "fc1ce51c-8bf0-4dc1-a59e-20675084341c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-101",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11167b64-edce-4dd8-bf40-c59388a94a9d", "4daa4b46-1232-4f61-a30f-c800f024234e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-102",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ebb73bbd-de1b-4e4b-9727-a6a2b345d5d1", "7895cdd4-e424-406d-a57d-069e5bf4b8a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "adbc88e6-708d-497b-99b0-51ed771d746d", "f0872df3-3fdb-448a-bf10-dd72d29d6649" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-104",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41c1ea76-e072-4659-bf01-1cbb84900c66", "5c19914b-d53c-487d-81c5-286a3c7ecc09" });
        }
    }
}
