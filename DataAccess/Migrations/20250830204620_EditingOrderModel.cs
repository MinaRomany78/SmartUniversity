using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EditingOrderModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PromoCodes_PromoCodeCode",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PromoCodeCode",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PromoCodeCode",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "PromoCodeId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-100",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "747b3220-8260-4cfa-bbfa-80064274afd0", "bc90d90b-04db-421b-bb26-102857ac43db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-101",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "217fb9f0-b614-4504-91da-2e323fd84d6b", "298c834b-1bd5-4690-b3cf-6bb45c781769" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-102",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f7f21441-a77f-45e7-82bb-094683a5af7e", "f6ce27d4-7215-4996-b2be-5d7f89b252e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a6ff9fd-94f4-4ab7-94b4-27da33677e8f", "bb77790f-507b-45dd-90f3-9d33bf92e173" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-104",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9ab0619-25f3-477c-beee-6793d199624d", "a94c08cd-519d-4ac9-a61c-ce5457d05e53" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PromoCodeId",
                table: "Orders",
                column: "PromoCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PromoCodes_PromoCodeId",
                table: "Orders",
                column: "PromoCodeId",
                principalTable: "PromoCodes",
                principalColumn: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PromoCodes_PromoCodeId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PromoCodeId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "PromoCodeId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PromoCodeCode",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

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
                name: "IX_Orders_PromoCodeCode",
                table: "Orders",
                column: "PromoCodeCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PromoCodes_PromoCodeCode",
                table: "Orders",
                column: "PromoCodeCode",
                principalTable: "PromoCodes",
                principalColumn: "Code");
        }
    }
}
