using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public DbSet<Student> Students { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<PromoCode> PromoCodes { get; set; }
        public DbSet<UniversityCourse> UniversityCourses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<OptionalCourse> OptionalCourses { get; set; }
        public DbSet<OptionalCourseEnrollment> OptionalCourseEnrollments { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }
        public DbSet<CourseAssistant> CourseAssistants { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<SubjectTask> SubjectTasks { get; set; }
        public DbSet<TaskSubmission> TaskSubmissions { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<CommunityPost> CommunityPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<SupportTicket> SupportTickets { get; set; }

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
                .HasForeignKey<Assistant>(a => a.ApplicationUserId);

            // Assistant ↔ Doctor (many-to-1)
            builder.Entity<Assistant>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Assistants)
                .HasForeignKey(a => a.DoctorID);

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

            // OptionalCourseEnrollment ↔ AppliedPromoCode (many-to-1)
            builder.Entity<OptionalCourseEnrollment>()
                .HasOne(e => e.AppliedPromoCodeEntity)
                .WithMany()
                .HasForeignKey(e => e.AppliedPromoCode)
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

            // Feedback relations
            builder.Entity<Feedback>()
                .HasOne(f => f.Assistant)
                .WithMany(a => a.Feedbacks)
                .HasForeignKey(f => f.AssistantID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
