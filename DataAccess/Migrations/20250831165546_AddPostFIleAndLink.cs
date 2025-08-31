using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPostFIleAndLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostFiles_CommunityPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "CommunityPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostLinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostLinks_CommunityPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "CommunityPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-100",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2c43c1fd-9d96-4301-8688-e13a21391e37", "c6605f20-af6a-4ec9-bb4b-3c06ed361e1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-101",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "216d36f7-4f36-4ccc-917e-7a5d557d02d0", "9023680a-9b85-413b-aee0-7fb94e24b459" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-102",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3557a2d4-55b4-4bb6-b486-55afe29667aa", "5eed6ce5-6539-4426-9295-f57b9a8e2e55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "597f311a-4cf6-471c-8631-ae11a27832a0", "3543bc4f-87de-4c1e-875c-fc6e04f836f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-104",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e142fcd9-7282-4623-8021-360997c9945d", "da0d52e7-6c4b-4b2f-a446-0ef077571999" });

            migrationBuilder.CreateIndex(
                name: "IX_PostFiles_PostId",
                table: "PostFiles",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostLinks_PostId",
                table: "PostLinks",
                column: "PostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostFiles");

            migrationBuilder.DropTable(
                name: "PostLinks");

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
        }
    }
}
