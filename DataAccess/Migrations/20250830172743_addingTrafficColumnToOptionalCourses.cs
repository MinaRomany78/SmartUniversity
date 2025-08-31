using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addingTrafficColumnToOptionalCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Traffic",
                table: "OptionalCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-100",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f3c1886-55d6-4e7c-a093-7eabfe6a0d0d", "f1d90849-12c6-4977-bee0-050abb3c78f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-101",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "31b374c2-0cea-4919-b93c-9c7e6e97667f", "88fbd9d9-6dad-4dea-ae02-e8c859f6d586" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-102",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "101a4e27-755a-43b7-ae97-786301339a1f", "4c2e7870-a890-4d01-9c57-a31c6bdd7c15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b54aebc-7676-4c47-8d1c-e4f9a58bcb71", "75b7dc65-37ac-45c2-b692-16c63b584270" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-104",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c1113ca4-8a5d-4a84-9e91-b813236a75e8", "7d102b96-9b6a-4328-92ee-27c485602456" });

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 300,
                column: "Traffic",
                value: 0);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 301,
                column: "Traffic",
                value: 0);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 302,
                column: "Traffic",
                value: 0);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 303,
                column: "Traffic",
                value: 0);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 304,
                column: "Traffic",
                value: 0);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 305,
                column: "Traffic",
                value: 0);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 306,
                column: "Traffic",
                value: 0);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 307,
                column: "Traffic",
                value: 0);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 308,
                column: "Traffic",
                value: 0);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 309,
                column: "Traffic",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Traffic",
                table: "OptionalCourses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-100",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c95f9775-b4fc-4aa0-a1ea-d4db9a763fe9", "4f06ca7e-40cf-4c09-b24f-51601e2e6bfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-101",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d60a6e56-8241-406b-96c4-874c62873f68", "0d7cc102-8d77-42a0-b25b-f83bdd22cb53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-102",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e69a5b19-9658-4cae-bf9c-ca7d8654d602", "dc28a22e-872d-4ae4-a708-58aa304da100" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "145d3b44-df10-402e-a6ca-340e211904da", "1897aa75-6f5d-4931-89cc-71a2157ebdb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-104",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0474a13d-284a-46cd-8dc9-e6df4b22d093", "96b2127f-3bf3-47b3-a2c5-fddf22dc0862" });
        }
    }
}
