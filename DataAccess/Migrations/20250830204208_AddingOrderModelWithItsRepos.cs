using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddingOrderModelWithItsRepos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OptionalCourseId = table.Column<int>(type: "int", nullable: false),
                    PricePaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PromoCodeId = table.Column<int>(type: "int", nullable: true),
                    PromoCodeCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_OptionalCourses_OptionalCourseId",
                        column: x => x.OptionalCourseId,
                        principalTable: "OptionalCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_PromoCodes_PromoCodeCode",
                        column: x => x.PromoCodeCode,
                        principalTable: "PromoCodes",
                        principalColumn: "Code");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-100",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be720aac-fb6e-4546-9c8b-14b56464218c", "d3d4e490-a6e6-4b51-b398-e6c7088ed550" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-101",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "556bf341-7737-40fb-890e-8ce25891212c", "dca08d30-9507-49c9-b443-12b4b75e7ae3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-102",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "024e437f-187a-43e7-a779-b4c5318667aa", "5127a3f9-f75f-4e0d-a629-4f01f3f38c46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d685d5d-1dcf-4f01-bf26-5561ca35037a", "757492c3-9f1e-4302-bb94-96eb924ed56c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-104",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f8361307-9719-437a-949b-937130126017", "1c9dd96b-ae5d-4bff-9641-5133d7c6a855" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OptionalCourseId",
                table: "Orders",
                column: "OptionalCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PromoCodeCode",
                table: "Orders",
                column: "PromoCodeCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

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
        }
    }
}
