using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixCourseReviewRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-100",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5f2fc50-e185-42ea-9524-3ae3230fd76d", "83c60879-673d-4310-bce5-d75cb5071a72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-101",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0cd39615-a846-4199-b626-b22043f43959", "298c74fb-4f8d-4bb5-abfe-285bfc226ac0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-102",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d1ac4a4c-e3bb-427b-ab1f-d460a4500d49", "e80c3aa9-4b9a-458c-8a63-d8412f37f588" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd0fd3d1-d878-4709-b04f-8475f7a1ad38", "0f85778a-35e9-45ec-b2c4-5d2055b68b24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-104",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0be51af4-b93a-4c80-9af2-0b79f977b583", "f0542a02-e369-43ca-b6cb-38ce4444cdb2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
