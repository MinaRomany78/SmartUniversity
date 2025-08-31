using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class modfiy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UniversityCourseId",
                table: "CommunityPosts",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-100",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0b1718a-7d47-4ad3-be12-be90a4c7081b", "cc85c233-addc-4b69-8c4c-7b11f7e15685" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-101",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "403663bf-eb4a-41c0-b402-7ba6433fecab", "13bed691-050e-411a-9652-d8b41f191210" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-102",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4aa8e76c-4180-41df-ae2c-3726e08a678f", "afbf0e1b-42d3-4307-a262-67178b2d81ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "acb83f50-cdec-4877-bb3a-28c9cbc75eca", "330783e0-1065-4372-a3eb-4d8d6dce53dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-104",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc7d04c7-c08b-47e3-a883-9931505d9f9f", "720a6004-f97b-4334-860b-b2502b55d008" });

            migrationBuilder.CreateIndex(
                name: "IX_CommunityPosts_UniversityCourseId",
                table: "CommunityPosts",
                column: "UniversityCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommunityPosts_UniversityCourses_UniversityCourseId",
                table: "CommunityPosts",
                column: "UniversityCourseId",
                principalTable: "UniversityCourses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommunityPosts_UniversityCourses_UniversityCourseId",
                table: "CommunityPosts");

            migrationBuilder.DropIndex(
                name: "IX_CommunityPosts_UniversityCourseId",
                table: "CommunityPosts");

            migrationBuilder.DropColumn(
                name: "UniversityCourseId",
                table: "CommunityPosts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-100",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "04711e2a-7c96-4c78-b109-f44e9e77a2f3", "669bf75c-0771-4b83-a89f-34adb659fdf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-101",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6587b456-5f46-4a57-b206-4daf3cf11f83", "bba4931e-511a-4a2b-9cda-6a294f4241d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-102",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "519a6a9a-d5e7-4c22-aeb0-0057213bdad3", "f8d8f81d-88b5-4123-91a8-6ca0e4ea33d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c68c7d5d-cff7-4c2c-a1e2-cb01bab24390", "9ebee9c7-87d5-4005-8a06-82271984e45a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-104",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "49737d22-f10f-47d2-a8cf-9942ba1f4d4b", "4b1be4b5-7ba7-4b12-9f24-c4c71dd64628" });
        }
    }
}
