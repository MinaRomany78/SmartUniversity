using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingDataIntoOptionalCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 300,
                column: "InstructorId",
                value: 101);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 301,
                column: "InstructorId",
                value: 101);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 302,
                column: "InstructorId",
                value: 102);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 303,
                column: "InstructorId",
                value: 102);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 304,
                column: "InstructorId",
                value: 103);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 305,
                column: "InstructorId",
                value: 103);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 306,
                column: "InstructorId",
                value: 104);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 307,
                column: "InstructorId",
                value: 104);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 308,
                column: "InstructorId",
                value: 100);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 309,
                column: "InstructorId",
                value: 100);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-100",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "30407b6d-893f-4865-a722-763560c7da1e", "8e7321f5-8bf6-426b-b385-e47801bde458" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-101",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "21f6bdd9-12fa-4496-bdcb-abe8d509e2f4", "c8845c4d-ddd9-4055-b207-d2d5550bfa7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-102",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4dd81b2f-5982-4921-8cf3-1ac560bb0f33", "04b17daa-9c21-4deb-9d32-49f98bc519f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-103",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aa605be7-ecb6-4267-8d98-3f83ea6337e7", "e22276fb-a4b4-4142-b0b8-0892655e91b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "inst-user-104",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "55293046-6096-4972-a5fb-6ed3d2238d99", "88ddaf1e-e677-48a4-bce7-f68543e39630" });

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 300,
                column: "InstructorId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 301,
                column: "InstructorId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 302,
                column: "InstructorId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 303,
                column: "InstructorId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 304,
                column: "InstructorId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 305,
                column: "InstructorId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 306,
                column: "InstructorId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 307,
                column: "InstructorId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 308,
                column: "InstructorId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 309,
                column: "InstructorId",
                value: 105);
        }
    }
}
