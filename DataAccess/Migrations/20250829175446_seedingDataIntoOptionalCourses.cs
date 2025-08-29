using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedingDataIntoOptionalCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 209);

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

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Description", "InstructorId", "IsAvailableForUniversityStudents", "MainImg", "Name", "Price", "PromoCode" },
                values: new object[,]
                {
                    { 300, "Intro to C# and .NET", 105, true, "csharp.png", "C# Basics", 800m, "PROMO10" },
                    { 301, "Learn EF Core ORM", 105, true, "efcore.png", "Entity Framework Core", 1200m, "PROMO10" },
                    { 302, "Frontend development with React", 105, false, "react.png", "React Fundamentals", 1500m, "PROMO10" },
                    { 303, "Learn Angular fast", 105, true, "angular.png", "Angular Crash Course", 1400m, "PROMO10" },
                    { 304, "Pandas, NumPy, and basics of ML", 105, false, "python.png", "Python for Data Science", 1600m, "PROMO10" },
                    { 305, "Intro to ML concepts", 105, true, "ml.png", "Machine Learning 101", 2000m, "PROMO10" },
                    { 306, "Wireframes & Prototyping", 105, true, "uiux.png", "UI/UX Advanced", 1300m, "PROMO10" },
                    { 307, "Cross-platform apps", 105, true, "flutter.png", "Mobile Development with Flutter", 1800m, "PROMO10" },
                    { 308, "Security principles and practices", 105, false, "cyber.png", "Cybersecurity Basics", 2200m, "PROMO10" },
                    { 309, "Azure fundamentals", 105, true, "azure.png", "Cloud with Azure", 2100m, "PROMO10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: 309);

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

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Description", "InstructorId", "IsAvailableForUniversityStudents", "MainImg", "Name", "Price", "PromoCode" },
                values: new object[,]
                {
                    { 200, "Intro to C# and .NET", 100, true, "csharp.png", "C# Basics", 800m, null },
                    { 201, "Learn EF Core ORM", 100, true, "efcore.png", "Entity Framework Core", 1200m, "PROMO10" },
                    { 202, "Frontend development with React", 101, false, "react.png", "React Fundamentals", 1500m, null },
                    { 203, "Learn Angular fast", 101, true, "angular.png", "Angular Crash Course", 1400m, null },
                    { 204, "Pandas, NumPy, and basics of ML", 102, false, "python.png", "Python for Data Science", 1600m, "STUDENT20" },
                    { 205, "Intro to ML concepts", 102, true, "ml.png", "Machine Learning 101", 2000m, null },
                    { 206, "Wireframes & Prototyping", 103, true, "uiux.png", "UI/UX Advanced", 1300m, null },
                    { 207, "Cross-platform apps", 103, true, "flutter.png", "Mobile Development with Flutter", 1800m, null },
                    { 208, "Security principles and practices", 104, false, "cyber.png", "Cybersecurity Basics", 2200m, null },
                    { 209, "Azure fundamentals", 104, true, "azure.png", "Cloud with Azure", 2100m, null }
                });
        }
    }
}
