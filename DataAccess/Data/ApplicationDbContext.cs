using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationUserOtp> ApplicationUserOtps { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<PromoCode> PromoCodes { get; set; }
        public DbSet<UniversityCourse> UniversityCourses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<OptionalCourse> OptionalCourses { get; set; }
        public DbSet<CourseReview> CourseReviews { get; set; }
        public DbSet<UserOptionalCourse> UserOptionalCourses { get; set; }
        public DbSet<AssistantCourse> AssistantCourses { get; set; }
        public DbSet<DoctorAssistant> DoctorAssistants { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<SubjectTask> SubjectTasks { get; set; }
        public DbSet<TaskSubmission> TaskSubmissions { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<CommunityPost> CommunityPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<SupportTicket> SupportTickets { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // PromoCode PK
            builder.Entity<PromoCode>()
                .HasKey(p => p.Code);

            // Student ↔ ApplicationUser (1-to-1)
            builder.Entity<Student>()
                .HasOne(s => s.ApplicationUser)
                .WithOne(u => u.Student)
                .HasForeignKey<Student>(s => s.ApplicationUserId);

            // Doctor ↔ ApplicationUser (1-to-1)
            builder.Entity<Doctor>()
                .HasOne(d => d.ApplicationUser)
                .WithOne(u => u.Doctor)
                .HasForeignKey<Doctor>(d => d.ApplicationUserId);

            // Assistant ↔ ApplicationUser (1-to-1)
            builder.Entity<Assistant>()
                .HasOne(a => a.ApplicationUser)
                .WithOne(u => u.Assistant)
                .HasForeignKey<Assistant>(a => a.ApplicationUserId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade على المستخدم

            // Student ↔ PromoCode (many-to-1)
            builder.Entity<Student>()
                .HasOne(s => s.PromoCodeEntity)
                .WithMany(p => p.Students)
                .HasForeignKey(s => s.PromoCode)
                .IsRequired(false);

            // OptionalCourse ↔ PromoCode (many-to-1)
            builder.Entity<OptionalCourse>()
                .HasOne(o => o.PromoCodeEntity)
                .WithMany(p => p.OptionalCourses)
                .HasForeignKey(o => o.PromoCode)
                .IsRequired(false);

            // Comment author (Student or Assistant) - no cascade
            builder.Entity<Comment>()
                .HasOne(c => c.Author)
                .WithMany()
                .HasForeignKey(c => c.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<CommunityPost>()
                .HasOne(p => p.Author)
                .WithMany()
                .HasForeignKey(p => p.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            // CommunityPost ↔ UniversityCourse (many-to-1)
            builder.Entity<CommunityPost>()
                .HasOne(p => p.UniversityCourse)
                .WithMany()
                .HasForeignKey(p => p.CourseID);

            // Feedback ↔ Assistant (no cascade)
            builder.Entity<Feedback>()
                .HasOne(f => f.Assistant)
                .WithMany(a => a.Feedbacks)
                .HasForeignKey(f => f.AssistantID)
                .OnDelete(DeleteBehavior.NoAction);

            // Feedback ↔ SubjectTask (no cascade) - منع المسارات المكررة
            builder.Entity<Feedback>()
                .HasOne(f => f.Task)
                .WithMany(t => t.Feedbacks)
                .HasForeignKey(f => f.TaskID)
                .OnDelete(DeleteBehavior.Restrict);

            // علاقة OptionalCourse <---> CourseReview
            builder.Entity<CourseReview>()
                .HasOne(r => r.Course)
                .WithMany(c => c.Reviews)
                .HasForeignKey(r => r.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            // علاقة CourseReview <---> ApplicationUser
            builder.Entity<CourseReview>()
                .HasOne(r => r.ApplicationUser)
                .WithMany() // لو حابب تضيف ICollection<CourseReview> في ApplicationUser حطها هنا
                .HasForeignKey(r => r.ApplicationUserId)
                .OnDelete(DeleteBehavior.Cascade);


            // Feedback ↔ Student (cascade ممكن نسيبها)
            builder.Entity<Feedback>()
                .HasOne(f => f.Student)
                .WithMany(s => s.Feedbacks)
                .HasForeignKey(f => f.StudentID)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Department>().HasData(
        new Department { Id = 1, Name = "General" },
        new Department { Id = 2, Name = "Computer Science" },
        new Department { Id = 3, Name = "Information Systems" }
            );

            // الترمات
            builder.Entity<Term>().HasData(
                new Term { Id = 1, Year = 1, TermNumber = 1 },
                new Term { Id = 2, Year = 1, TermNumber = 2 },
                new Term { Id = 3, Year = 2, TermNumber = 1 },
                new Term { Id = 4, Year = 2, TermNumber = 2 },
                new Term { Id = 5, Year = 3, TermNumber = 1 },
                new Term { Id = 6, Year = 3, TermNumber = 2 },
                new Term { Id = 7, Year = 4, TermNumber = 1 },
                new Term { Id = 8, Year = 4, TermNumber = 2 }
            );
            builder.Entity<UniversityCourse>().HasData(
    // ---- Year 1 Term 1 (General)
                new UniversityCourse { Id = 1, Name = "Mathematics 1", CreditHours = 3, DepartmentID = 1, TermId = 1 },
                new UniversityCourse { Id = 2, Name = "Programming Basics", CreditHours = 3, DepartmentID = 1, TermId = 1 },
                new UniversityCourse { Id = 3, Name = "Physics 1", CreditHours = 3, DepartmentID = 1, TermId = 1 },
                new UniversityCourse { Id = 4, Name = "English 1", CreditHours = 3, DepartmentID = 1, TermId = 1 },
                new UniversityCourse { Id = 5, Name = "Introduction to IT", CreditHours = 3, DepartmentID = 1, TermId = 1 },
                new UniversityCourse { Id = 6, Name = "Critical Thinking", CreditHours = 3, DepartmentID = 1, TermId = 1 },

                // ---- Year 1 Term 2 (General)
                new UniversityCourse { Id = 7, Name = "Mathematics 2", CreditHours = 3, DepartmentID = 1, TermId = 2 },
                new UniversityCourse { Id = 8, Name = "Object Oriented Programming", CreditHours = 3, DepartmentID = 1, TermId = 2 },
                new UniversityCourse { Id = 9, Name = "Physics 2", CreditHours = 3, DepartmentID = 1, TermId = 2 },
                new UniversityCourse { Id = 10, Name = "English 2", CreditHours = 3, DepartmentID = 1, TermId = 2 },
                new UniversityCourse { Id = 11, Name = "Introduction to Database", CreditHours = 3, DepartmentID = 1, TermId = 2 },
                new UniversityCourse { Id = 12, Name = "Communication Skills", CreditHours = 3, DepartmentID = 1, TermId = 2 },

                // ---- Year 2 Term 1 (General)
                new UniversityCourse { Id = 13, Name = "Mathematics 3", CreditHours = 3, DepartmentID = 1, TermId = 3 },
                new UniversityCourse { Id = 14, Name = "Data Structures", CreditHours = 3, DepartmentID = 1, TermId = 3 },
                new UniversityCourse { Id = 15, Name = "Computer Organization", CreditHours = 3, DepartmentID = 1, TermId = 3 },
                new UniversityCourse { Id = 16, Name = "Probability & Statistics", CreditHours = 3, DepartmentID = 1, TermId = 3 },
                new UniversityCourse { Id = 17, Name = "Operating Systems Basics", CreditHours = 3, DepartmentID = 1, TermId = 3 },
                new UniversityCourse { Id = 18, Name = "Ethics", CreditHours = 3, DepartmentID = 1, TermId = 3 },

                // ---- Year 2 Term 2 (General)
                new UniversityCourse { Id = 19, Name = "Mathematics 4", CreditHours = 3, DepartmentID = 1, TermId = 4 },
                new UniversityCourse { Id = 20, Name = "Algorithms", CreditHours = 3, DepartmentID = 1, TermId = 4 },
                new UniversityCourse { Id = 21, Name = "Digital Logic", CreditHours = 3, DepartmentID = 1, TermId = 4 },
                new UniversityCourse { Id = 22, Name = "Software Engineering Basics", CreditHours = 3, DepartmentID = 1, TermId = 4 },
                new UniversityCourse { Id = 23, Name = "Database Systems", CreditHours = 3, DepartmentID = 1, TermId = 4 },
                new UniversityCourse { Id = 24, Name = "Technical Writing", CreditHours = 3, DepartmentID = 1, TermId = 4 },

                // ---- Year 3 Term 1 (Specialization - CS)
                new UniversityCourse { Id = 25, Name = "Advanced Algorithms", CreditHours = 3, DepartmentID = 2, TermId = 5 },
                new UniversityCourse { Id = 26, Name = "Theory of Computation", CreditHours = 3, DepartmentID = 2, TermId = 5 },
                new UniversityCourse { Id = 27, Name = "Operating Systems", CreditHours = 3, DepartmentID = 2, TermId = 5 },
                new UniversityCourse { Id = 28, Name = "Computer Networks", CreditHours = 3, DepartmentID = 2, TermId = 5 },
                new UniversityCourse { Id = 29, Name = "Artificial Intelligence", CreditHours = 3, DepartmentID = 2, TermId = 5 },
                new UniversityCourse { Id = 30, Name = "Compiler Design", CreditHours = 3, DepartmentID = 2, TermId = 5 },

                // ---- Year 3 Term 1 (Specialization - IS)
                new UniversityCourse { Id = 31, Name = "Information Systems Analysis", CreditHours = 3, DepartmentID = 3, TermId = 5 },
                new UniversityCourse { Id = 32, Name = "Business Process Management", CreditHours = 3, DepartmentID = 3, TermId = 5 },
                new UniversityCourse { Id = 33, Name = "Database Administration", CreditHours = 3, DepartmentID = 3, TermId = 5 },
                new UniversityCourse { Id = 34, Name = "Enterprise Systems", CreditHours = 3, DepartmentID = 3, TermId = 5 },
                new UniversityCourse { Id = 35, Name = "Systems Security", CreditHours = 3, DepartmentID = 3, TermId = 5 },
                new UniversityCourse { Id = 36, Name = "Decision Support Systems", CreditHours = 3, DepartmentID = 3, TermId = 5 },

                // ---- Year 3 Term 2 (Specialization - CS)
            new UniversityCourse { Id = 37, Name = "Parallel Computing", CreditHours = 3, DepartmentID = 2, TermId = 6 },
            new UniversityCourse { Id = 38, Name = "Advanced Computer Networks", CreditHours = 3, DepartmentID = 2, TermId = 6 },
            new UniversityCourse { Id = 39, Name = "Machine Learning", CreditHours = 3, DepartmentID = 2, TermId = 6 },
            new UniversityCourse { Id = 40, Name = "Database Systems Advanced", CreditHours = 3, DepartmentID = 2, TermId = 6 },
            new UniversityCourse { Id = 41, Name = "Web Technologies", CreditHours = 3, DepartmentID = 2, TermId = 6 },
            new UniversityCourse { Id = 42, Name = "Human Computer Interaction", CreditHours = 3, DepartmentID = 2, TermId = 6 },

            // ---- Year 3 Term 2 (Specialization - IS)
            new UniversityCourse { Id = 43, Name = "E-Business Systems", CreditHours = 3, DepartmentID = 3, TermId = 6 },
            new UniversityCourse { Id = 44, Name = "Knowledge Management", CreditHours = 3, DepartmentID = 3, TermId = 6 },
            new UniversityCourse { Id = 45, Name = "Advanced Systems Security", CreditHours = 3, DepartmentID = 3, TermId = 6 },
            new UniversityCourse { Id = 46, Name = "Big Data Analytics", CreditHours = 3, DepartmentID = 3, TermId = 6 },
            new UniversityCourse { Id = 47, Name = "Cloud Computing", CreditHours = 3, DepartmentID = 3, TermId = 6 },
            new UniversityCourse { Id = 48, Name = "IT Project Management", CreditHours = 3, DepartmentID = 3, TermId = 6 },

            // ---- Year 4 Term 1 (Specialization - CS)
            new UniversityCourse { Id = 49, Name = "Computer Graphics", CreditHours = 3, DepartmentID = 2, TermId = 7 },
            new UniversityCourse { Id = 50, Name = "Cyber Security", CreditHours = 3, DepartmentID = 2, TermId = 7 },
            new UniversityCourse { Id = 51, Name = "Natural Language Processing", CreditHours = 3, DepartmentID = 2, TermId = 7 },
            new UniversityCourse { Id = 52, Name = "Advanced Artificial Intelligence", CreditHours = 3, DepartmentID = 2, TermId = 7 },
            new UniversityCourse { Id = 53, Name = "Software Engineering Advanced", CreditHours = 3, DepartmentID = 2, TermId = 7 },
            new UniversityCourse { Id = 54, Name = "Data Mining", CreditHours = 3, DepartmentID = 2, TermId = 7 },

            // ---- Year 4 Term 1 (Specialization - IS)
            new UniversityCourse { Id = 55, Name = "Enterprise Resource Planning", CreditHours = 3, DepartmentID = 3, TermId = 7 },
            new UniversityCourse { Id = 56, Name = "Advanced Decision Support", CreditHours = 3, DepartmentID = 3, TermId = 7 },
            new UniversityCourse { Id = 57, Name = "Business Intelligence", CreditHours = 3, DepartmentID = 3, TermId = 7 },
            new UniversityCourse { Id = 58, Name = "Information Systems Strategy", CreditHours = 3, DepartmentID = 3, TermId = 7 },
            new UniversityCourse { Id = 59, Name = "Cybersecurity for IS", CreditHours = 3, DepartmentID = 3, TermId = 7 },
            new UniversityCourse { Id = 60, Name = "Mobile Systems", CreditHours = 3, DepartmentID = 3, TermId = 7 },

            // ---- Year 4 Term 2 (Specialization - CS)
            new UniversityCourse { Id = 61, Name = "Advanced Computer Vision", CreditHours = 3, DepartmentID = 2, TermId = 8 },
            new UniversityCourse { Id = 62, Name = "Robotics", CreditHours = 3, DepartmentID = 2, TermId = 8 },
            new UniversityCourse { Id = 63, Name = "Cloud Native Applications", CreditHours = 3, DepartmentID = 2, TermId = 8 },
            new UniversityCourse { Id = 64, Name = "Capstone Project (CS)", CreditHours = 3, DepartmentID = 2, TermId = 8 },
            new UniversityCourse { Id = 65, Name = "Advanced Data Mining", CreditHours = 3, DepartmentID = 2, TermId = 8 },
            new UniversityCourse { Id = 66, Name = "Ethical Hacking", CreditHours = 3, DepartmentID = 2, TermId = 8 },

            // ---- Year 4 Term 2 (Specialization - IS)
            new UniversityCourse { Id = 67, Name = "Digital Transformation", CreditHours = 3, DepartmentID = 3, TermId = 8 },
            new UniversityCourse { Id = 68, Name = "Information Governance", CreditHours = 3, DepartmentID = 3, TermId = 8 },
            new UniversityCourse { Id = 69, Name = "Enterprise Architecture", CreditHours = 3, DepartmentID = 3, TermId = 8 },
            new UniversityCourse { Id = 70, Name = "Capstone Project (IS)", CreditHours = 3, DepartmentID = 3, TermId = 8 },
            new UniversityCourse { Id = 71, Name = "Advanced Business Intelligence", CreditHours = 3, DepartmentID = 3, TermId = 8 },
            new UniversityCourse { Id = 72, Name = "IT Governance & Compliance", CreditHours = 3, DepartmentID = 3, TermId = 8 }


 
            );


            // --- AspNetUsers (Fake data) ---
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser { Id = "inst-user-100", UserName = "ahmed@test.com", NormalizedUserName = "AHMED@TEST.COM", Email = "ahmed@test.com", NormalizedEmail = "AHMED@TEST.COM", EmailConfirmed = true, PasswordHash = "FAKE_HASH", FirstName = "Ahmed", LastName = "Kamal", FullName = "Ahmed Kamal" },
                new ApplicationUser { Id = "inst-user-101", UserName = "mona@test.com", NormalizedUserName = "MONA@TEST.COM", Email = "mona@test.com", NormalizedEmail = "MONA@TEST.COM", EmailConfirmed = true, PasswordHash = "FAKE_HASH", FirstName = "Mona", LastName = "Ali", FullName = "Mona Ali" },
                new ApplicationUser { Id = "inst-user-102", UserName = "hossam@test.com", NormalizedUserName = "HOSSAM@TEST.COM", Email = "hossam@test.com", NormalizedEmail = "HOSSAM@TEST.COM", EmailConfirmed = true, PasswordHash = "FAKE_HASH", FirstName = "Hossam", LastName = "Yehia", FullName = "Hossam Yehia" },
                new ApplicationUser { Id = "inst-user-103", UserName = "sara@test.com", NormalizedUserName = "SARA@TEST.COM", Email = "sara@test.com", NormalizedEmail = "SARA@TEST.COM", EmailConfirmed = true, PasswordHash = "FAKE_HASH", FirstName = "Sara", LastName = "Ibrahim", FullName = "Sara Ibrahim" },
                new ApplicationUser { Id = "inst-user-104", UserName = "khaled@test.com", NormalizedUserName = "KHALED@TEST.COM", Email = "khaled@test.com", NormalizedEmail = "KHALED@TEST.COM", EmailConfirmed = true, PasswordHash = "FAKE_HASH", FirstName = "Khaled", LastName = "Mostafa", FullName = "Khaled Mostafa" }
            );

            // --- Instructors ---
            builder.Entity<Instructor>().HasData(
                new Instructor { Id = 100, ApplicationUserId = "inst-user-100" },
                new Instructor { Id = 101, ApplicationUserId = "inst-user-101" },
                new Instructor { Id = 102, ApplicationUserId = "inst-user-102" },
                new Instructor { Id = 103, ApplicationUserId = "inst-user-103" },
                new Instructor { Id = 104, ApplicationUserId = "inst-user-104" }
            );

            // --- PromoCodes ---
            builder.Entity<PromoCode>().HasData(
                new PromoCode { Code = "PROMO10", DiscountPercent = 10, IsForUniversityStudentsOnly = false },
                new PromoCode { Code = "STUDENT20", DiscountPercent = 20, IsForUniversityStudentsOnly = true }
            );

            builder.Entity<OptionalCourse>().HasData(
                new OptionalCourse { Id = 300, Name = "C# Basics", Description = "Intro to C# and .NET", MainImg = "csharp.png", Price = 800, IsAvailableForUniversityStudents = true, InstructorId = 101, PromoCode = "PROMO10" },
                new OptionalCourse { Id = 301, Name = "Entity Framework Core", Description = "Learn EF Core ORM", MainImg = "efcore.png", Price = 1200, IsAvailableForUniversityStudents = true, InstructorId = 101, PromoCode = "PROMO10" },
                new OptionalCourse { Id = 302, Name = "React Fundamentals", Description = "Frontend development with React", MainImg = "react.png", Price = 1500, IsAvailableForUniversityStudents = false, InstructorId = 102, PromoCode = "PROMO10" },
                new OptionalCourse { Id = 303, Name = "Angular Crash Course", Description = "Learn Angular fast", MainImg = "angular.png", Price = 1400, IsAvailableForUniversityStudents = true, InstructorId = 102 , PromoCode = "PROMO10" },
                new OptionalCourse { Id = 304, Name = "Python for Data Science", Description = "Pandas, NumPy, and basics of ML", MainImg = "python.png", Price = 1600, IsAvailableForUniversityStudents = false, InstructorId = 103, PromoCode = "PROMO10" },
                new OptionalCourse { Id = 305, Name = "Machine Learning 101", Description = "Intro to ML concepts", MainImg = "ml.png", Price = 2000, IsAvailableForUniversityStudents = true, InstructorId = 103, PromoCode = "PROMO10" },
                new OptionalCourse { Id = 306, Name = "UI/UX Advanced", Description = "Wireframes & Prototyping", MainImg = "uiux.png", Price = 1300, IsAvailableForUniversityStudents = true, InstructorId = 104, PromoCode = "PROMO10" },
                new OptionalCourse { Id = 307, Name = "Mobile Development with Flutter", Description = "Cross-platform apps", MainImg = "flutter.png", Price = 1800, IsAvailableForUniversityStudents = true, InstructorId = 104, PromoCode = "PROMO10" },
                new OptionalCourse { Id = 308, Name = "Cybersecurity Basics", Description = "Security principles and practices", MainImg = "cyber.png", Price = 2200, IsAvailableForUniversityStudents = false, InstructorId = 100, PromoCode = "PROMO10" },
                new OptionalCourse { Id = 309, Name = "Cloud with Azure", Description = "Azure fundamentals", MainImg = "azure.png", Price = 2100, IsAvailableForUniversityStudents = true, InstructorId = 100, PromoCode = "PROMO10" }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
                warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
    }
}
