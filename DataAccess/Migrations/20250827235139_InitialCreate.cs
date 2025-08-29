using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenerateEmail = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PromoCodes",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsForUniversityStudentsOnly = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoCodes", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "SupportTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResolvedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    SenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminResponse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportTickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TermNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserOtps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtpNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserOtps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUserOtps_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assistants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assistants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assistants_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsUniversityStudent = table.Column<bool>(type: "bit", nullable: false),
                    PromoCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TermId = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_PromoCodes_PromoCode",
                        column: x => x.PromoCode,
                        principalTable: "PromoCodes",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_Students_Terms_TermId",
                        column: x => x.TermId,
                        principalTable: "Terms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UniversityCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditHours = table.Column<int>(type: "int", nullable: false),
                    DoctorID = table.Column<int>(type: "int", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    TermId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UniversityCourses_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UniversityCourses_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UniversityCourses_Terms_TermId",
                        column: x => x.TermId,
                        principalTable: "Terms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OptionalCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsAvailableForUniversityStudents = table.Column<bool>(type: "bit", nullable: false),
                    PromoCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionalCourses_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OptionalCourses_PromoCodes_PromoCode",
                        column: x => x.PromoCode,
                        principalTable: "PromoCodes",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateTable(
                name: "AssistantCourses",
                columns: table => new
                {
                    AssistantId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssistantCourses", x => new { x.AssistantId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_AssistantCourses_Assistants_AssistantId",
                        column: x => x.AssistantId,
                        principalTable: "Assistants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssistantCourses_UniversityCourses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "UniversityCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommunityPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunityPosts_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CommunityPosts_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CommunityPosts_UniversityCourses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "UniversityCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorAssistants",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    AssistantId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorAssistants", x => new { x.DoctorId, x.AssistantId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_DoctorAssistants_Assistants_AssistantId",
                        column: x => x.AssistantId,
                        principalTable: "Assistants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DoctorAssistants_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DoctorAssistants_UniversityCourses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "UniversityCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    UniversityCourseID = table.Column<int>(type: "int", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    Term = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Enrollments_UniversityCourses_UniversityCourseID",
                        column: x => x.UniversityCourseID,
                        principalTable: "UniversityCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversityCourseID = table.Column<int>(type: "int", nullable: false),
                    MaterialLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_UniversityCourses_UniversityCourseID",
                        column: x => x.UniversityCourseID,
                        principalTable: "UniversityCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversityCourseID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignedBy = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectTasks_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectTasks_UniversityCourses_UniversityCourseID",
                        column: x => x.UniversityCourseID,
                        principalTable: "UniversityCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserOptionalCourses",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OptionalCourseId = table.Column<int>(type: "int", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppliedPromoCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppliedPromoCodeEntityCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOptionalCourses", x => new { x.ApplicationUserId, x.OptionalCourseId }).Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_UserOptionalCourses_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UserOptionalCourses_OptionalCourses_OptionalCourseId",
                        column: x => x.OptionalCourseId,
                        principalTable: "OptionalCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UserOptionalCourses_PromoCodes_AppliedPromoCodeEntityCode",
                        column: x => x.AppliedPromoCodeEntityCode,
                        principalTable: "PromoCodes",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostID = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssistantId = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Assistants_AssistantId",
                        column: x => x.AssistantId,
                        principalTable: "Assistants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_CommunityPosts_PostID",
                        column: x => x.PostID,
                        principalTable: "CommunityPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    AssistantID = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReplyFromStudent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Assistants_AssistantID",
                        column: x => x.AssistantID,
                        principalTable: "Assistants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Feedbacks_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_SubjectTasks_TaskID",
                        column: x => x.TaskID,
                        principalTable: "SubjectTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskSubmissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Grade = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskSubmissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskSubmissions_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TaskSubmissions_SubjectTasks_TaskID",
                        column: x => x.TaskID,
                        principalTable: "SubjectTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "FullName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "inst-user-100", 0, null, "f66bfd5c-e8d4-43be-95fa-101ec9ed41e9", "ahmed@test.com", true, "Ahmed", "Ahmed Kamal", "Kamal", false, null, "AHMED@TEST.COM", "AHMED@TEST.COM", "FAKE_HASH", null, false, "f6fe61d4-a282-4a26-a162-8ee520cfa31a", false, "ahmed@test.com" },
                    { "inst-user-101", 0, null, "d429803b-27c6-4baa-9119-d5a5c4090680", "mona@test.com", true, "Mona", "Mona Ali", "Ali", false, null, "MONA@TEST.COM", "MONA@TEST.COM", "FAKE_HASH", null, false, "2b3c053a-efba-43e4-9efb-d7e67424958d", false, "mona@test.com" },
                    { "inst-user-102", 0, null, "54ba170e-aa1a-496d-ab41-a85bc853df70", "hossam@test.com", true, "Hossam", "Hossam Yehia", "Yehia", false, null, "HOSSAM@TEST.COM", "HOSSAM@TEST.COM", "FAKE_HASH", null, false, "246cc983-0586-41ce-97b7-2a74c5d83cbb", false, "hossam@test.com" },
                    { "inst-user-103", 0, null, "e69371f6-d527-4a82-b11c-d145b56264ae", "sara@test.com", true, "Sara", "Sara Ibrahim", "Ibrahim", false, null, "SARA@TEST.COM", "SARA@TEST.COM", "FAKE_HASH", null, false, "6ab0e434-75cd-4b4d-8e7e-45e3399969a8", false, "sara@test.com" },
                    { "inst-user-104", 0, null, "795f6887-d2da-40c9-8240-f13f7632e598", "khaled@test.com", true, "Khaled", "Khaled Mostafa", "Mostafa", false, null, "KHALED@TEST.COM", "KHALED@TEST.COM", "FAKE_HASH", null, false, "e3cd6fa4-23f5-4719-96ca-17925715b071", false, "khaled@test.com" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "General" },
                    { 2, "Computer Science" },
                    { 3, "Information Systems" }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "Code", "DiscountPercent", "IsForUniversityStudentsOnly" },
                values: new object[,]
                {
                    { "PROMO10", 10m, false },
                    { "STUDENT20", 20m, true }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "TermNumber", "Year" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 1, 2 },
                    { 4, 2, 2 },
                    { 5, 1, 3 },
                    { 6, 2, 3 },
                    { 7, 1, 4 },
                    { 8, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "ApplicationUserId" },
                values: new object[,]
                {
                    { 100, "inst-user-100" },
                    { 101, "inst-user-101" },
                    { 102, "inst-user-102" },
                    { 103, "inst-user-103" },
                    { 104, "inst-user-104" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserOtps_ApplicationUserId",
                table: "ApplicationUserOtps",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssistantCourses_CourseId",
                table: "AssistantCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Assistants_ApplicationUserId",
                table: "Assistants",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AssistantId",
                table: "Comments",
                column: "AssistantId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostID",
                table: "Comments",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_StudentId",
                table: "Comments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityPosts_AuthorId",
                table: "CommunityPosts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityPosts_CourseID",
                table: "CommunityPosts",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityPosts_StudentId",
                table: "CommunityPosts",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorAssistants_AssistantId",
                table: "DoctorAssistants",
                column: "AssistantId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorAssistants_CourseId",
                table: "DoctorAssistants",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_ApplicationUserId",
                table: "Doctors",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentID",
                table: "Enrollments",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_UniversityCourseID",
                table: "Enrollments",
                column: "UniversityCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_AssistantID",
                table: "Feedbacks",
                column: "AssistantID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_StudentID",
                table: "Feedbacks",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_TaskID",
                table: "Feedbacks",
                column: "TaskID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_ApplicationUserId",
                table: "Instructors",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_UniversityCourseID",
                table: "Materials",
                column: "UniversityCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalCourses_InstructorId",
                table: "OptionalCourses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalCourses_PromoCode",
                table: "OptionalCourses",
                column: "PromoCode");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ApplicationUserId",
                table: "Students",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentID",
                table: "Students",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_PromoCode",
                table: "Students",
                column: "PromoCode");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TermId",
                table: "Students",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTasks_DoctorId",
                table: "SubjectTasks",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTasks_UniversityCourseID",
                table: "SubjectTasks",
                column: "UniversityCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskSubmissions_StudentID",
                table: "TaskSubmissions",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskSubmissions_TaskID",
                table: "TaskSubmissions",
                column: "TaskID");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityCourses_DepartmentID",
                table: "UniversityCourses",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityCourses_DoctorID",
                table: "UniversityCourses",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityCourses_TermId",
                table: "UniversityCourses",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOptionalCourses_AppliedPromoCodeEntityCode",
                table: "UserOptionalCourses",
                column: "AppliedPromoCodeEntityCode");

            migrationBuilder.CreateIndex(
                name: "IX_UserOptionalCourses_OptionalCourseId",
                table: "UserOptionalCourses",
                column: "OptionalCourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "ApplicationUserOtps");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AssistantCourses");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "DoctorAssistants");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "SupportTickets");

            migrationBuilder.DropTable(
                name: "TaskSubmissions");

            migrationBuilder.DropTable(
                name: "UserOptionalCourses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CommunityPosts");

            migrationBuilder.DropTable(
                name: "Assistants");

            migrationBuilder.DropTable(
                name: "SubjectTasks");

            migrationBuilder.DropTable(
                name: "OptionalCourses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "UniversityCourses");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "PromoCodes");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Terms");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
