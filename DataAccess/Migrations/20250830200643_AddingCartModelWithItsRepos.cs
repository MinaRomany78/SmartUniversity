using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddingCartModelWithItsRepos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OptionalCourseId = table.Column<int>(type: "int", nullable: false),
                    AppliedPromoCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => new { x.ApplicationUserId, x.OptionalCourseId });
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carts_OptionalCourses_OptionalCourseId",
                        column: x => x.OptionalCourseId,
                        principalTable: "OptionalCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-100",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eddf812f-59c2-45ed-aeee-b9f3b696f9c4", "f13662d0-ccf1-4200-bb20-bb4247c570cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-101",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1dde393-cfe3-4904-b803-1ec6587f88cd", "e3f1a679-7eb2-494f-ba95-5c58e0005e86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-102",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "009598e7-43e7-42b3-b54e-45c2c86aa4b9", "39f04fb1-47ec-4f0f-8d6b-6529f9434db3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d03d11b-0eac-4d8c-8287-62faab68bf19", "9df73c2c-26a1-4837-8658-619a2faef4c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-104",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d96d913-a120-4d49-8387-9e1c817ecc5a", "c86a6ef3-4426-44f0-8625-f8cc69c7781b" });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_OptionalCourseId",
                table: "Carts",
                column: "OptionalCourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

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
    }
}
