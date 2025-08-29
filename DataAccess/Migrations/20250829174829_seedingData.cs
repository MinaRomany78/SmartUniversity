using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-100",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90e33f22-8f10-45ca-b21e-ab1512754aa8", "fa430bfd-606c-45f5-ae94-9446402961d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-101",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11b2c74a-abad-4c05-93da-b674284146e7", "49643e6d-cef3-4c86-ac71-b06c528dd7d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-102",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70205ede-1bdd-4b64-a853-5ee327c42afd", "5ef73956-8984-4531-8c0b-9b30dd1baa4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "419a4c89-2fdc-4459-8cb4-468df981901c", "1e6e1fda-1afe-4368-b113-beac1164e62f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-104",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d78d268c-e70f-4f32-8a29-33b0275f8f41", "f057e07e-7ef4-413e-8ada-106555f98c09" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-100",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f66bfd5c-e8d4-43be-95fa-101ec9ed41e9", "f6fe61d4-a282-4a26-a162-8ee520cfa31a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-101",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d429803b-27c6-4baa-9119-d5a5c4090680", "2b3c053a-efba-43e4-9efb-d7e67424958d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-102",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "54ba170e-aa1a-496d-ab41-a85bc853df70", "246cc983-0586-41ce-97b7-2a74c5d83cbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e69371f6-d527-4a82-b11c-d145b56264ae", "6ab0e434-75cd-4b4d-8e7e-45e3399969a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-104",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "795f6887-d2da-40c9-8240-f13f7632e598", "e3cd6fa4-23f5-4719-96ca-17925715b071" });
        }
    }
}
