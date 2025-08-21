using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeederDataCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UniversityCourses",
                columns: new[] { "Id", "CreditHours", "DepartmentID", "Description", "DoctorID", "Name", "TermId" },
                values: new object[,]
                {
                    { 1, 3, 1, "", null, "Mathematics 1", 1 },
                    { 2, 3, 1, "", null, "Programming Basics", 1 },
                    { 3, 3, 1, "", null, "Physics 1", 1 },
                    { 4, 3, 1, "", null, "English 1", 1 },
                    { 5, 3, 1, "", null, "Introduction to IT", 1 },
                    { 6, 3, 1, "", null, "Critical Thinking", 1 },
                    { 7, 3, 1, "", null, "Mathematics 2", 2 },
                    { 8, 3, 1, "", null, "Object Oriented Programming", 2 },
                    { 9, 3, 1, "", null, "Physics 2", 2 },
                    { 10, 3, 1, "", null, "English 2", 2 },
                    { 11, 3, 1, "", null, "Introduction to Database", 2 },
                    { 12, 3, 1, "", null, "Communication Skills", 2 },
                    { 13, 3, 1, "", null, "Mathematics 3", 3 },
                    { 14, 3, 1, "", null, "Data Structures", 3 },
                    { 15, 3, 1, "", null, "Computer Organization", 3 },
                    { 16, 3, 1, "", null, "Probability & Statistics", 3 },
                    { 17, 3, 1, "", null, "Operating Systems Basics", 3 },
                    { 18, 3, 1, "", null, "Ethics", 3 },
                    { 19, 3, 1, "", null, "Mathematics 4", 4 },
                    { 20, 3, 1, "", null, "Algorithms", 4 },
                    { 21, 3, 1, "", null, "Digital Logic", 4 },
                    { 22, 3, 1, "", null, "Software Engineering Basics", 4 },
                    { 23, 3, 1, "", null, "Database Systems", 4 },
                    { 24, 3, 1, "", null, "Technical Writing", 4 },
                    { 25, 3, 2, "", null, "Advanced Algorithms", 5 },
                    { 26, 3, 2, "", null, "Theory of Computation", 5 },
                    { 27, 3, 2, "", null, "Operating Systems", 5 },
                    { 28, 3, 2, "", null, "Computer Networks", 5 },
                    { 29, 3, 2, "", null, "Artificial Intelligence", 5 },
                    { 30, 3, 2, "", null, "Compiler Design", 5 },
                    { 31, 3, 3, "", null, "Information Systems Analysis", 5 },
                    { 32, 3, 3, "", null, "Business Process Management", 5 },
                    { 33, 3, 3, "", null, "Database Administration", 5 },
                    { 34, 3, 3, "", null, "Enterprise Systems", 5 },
                    { 35, 3, 3, "", null, "Systems Security", 5 },
                    { 36, 3, 3, "", null, "Decision Support Systems", 5 },
                    { 37, 3, 2, "", null, "Parallel Computing", 6 },
                    { 38, 3, 2, "", null, "Advanced Computer Networks", 6 },
                    { 39, 3, 2, "", null, "Machine Learning", 6 },
                    { 40, 3, 2, "", null, "Database Systems Advanced", 6 },
                    { 41, 3, 2, "", null, "Web Technologies", 6 },
                    { 42, 3, 2, "", null, "Human Computer Interaction", 6 },
                    { 43, 3, 3, "", null, "E-Business Systems", 6 },
                    { 44, 3, 3, "", null, "Knowledge Management", 6 },
                    { 45, 3, 3, "", null, "Advanced Systems Security", 6 },
                    { 46, 3, 3, "", null, "Big Data Analytics", 6 },
                    { 47, 3, 3, "", null, "Cloud Computing", 6 },
                    { 48, 3, 3, "", null, "IT Project Management", 6 },
                    { 49, 3, 2, "", null, "Computer Graphics", 7 },
                    { 50, 3, 2, "", null, "Cyber Security", 7 },
                    { 51, 3, 2, "", null, "Natural Language Processing", 7 },
                    { 52, 3, 2, "", null, "Advanced Artificial Intelligence", 7 },
                    { 53, 3, 2, "", null, "Software Engineering Advanced", 7 },
                    { 54, 3, 2, "", null, "Data Mining", 7 },
                    { 55, 3, 3, "", null, "Enterprise Resource Planning", 7 },
                    { 56, 3, 3, "", null, "Advanced Decision Support", 7 },
                    { 57, 3, 3, "", null, "Business Intelligence", 7 },
                    { 58, 3, 3, "", null, "Information Systems Strategy", 7 },
                    { 59, 3, 3, "", null, "Cybersecurity for IS", 7 },
                    { 60, 3, 3, "", null, "Mobile Systems", 7 },
                    { 61, 3, 2, "", null, "Advanced Computer Vision", 8 },
                    { 62, 3, 2, "", null, "Robotics", 8 },
                    { 63, 3, 2, "", null, "Cloud Native Applications", 8 },
                    { 64, 3, 2, "", null, "Capstone Project (CS)", 8 },
                    { 65, 3, 2, "", null, "Advanced Data Mining", 8 },
                    { 66, 3, 2, "", null, "Ethical Hacking", 8 },
                    { 67, 3, 3, "", null, "Digital Transformation", 8 },
                    { 68, 3, 3, "", null, "Information Governance", 8 },
                    { 69, 3, 3, "", null, "Enterprise Architecture", 8 },
                    { 70, 3, 3, "", null, "Capstone Project (IS)", 8 },
                    { 71, 3, 3, "", null, "Advanced Business Intelligence", 8 },
                    { 72, 3, 3, "", null, "IT Governance & Compliance", 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumn: "Id",
                keyValue: 72);
        }
    }
}
