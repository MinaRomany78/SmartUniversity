// Program.cs
using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

using DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();


builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


// Register custom repositories (سجل كل إنترفيس مع implementation)
builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();
builder.Services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
builder.Services.AddScoped<IAssistantRepository, AssistantRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<ICommunityPostRepository, CommunityPostRepository>();
builder.Services.AddScoped<ICourseAssignmentRepository, CourseAssignmentRepository>();
builder.Services.AddScoped<ICourseAssistantRepository, CourseAssistantRepository>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();
builder.Services.AddScoped<IFeedbackRepository, FeedbackRepository>();
builder.Services.AddScoped<IMaterialRepository, MaterialRepository>();
builder.Services.AddScoped<IOptionalCourseRepository, OptionalCourseRepository>();
builder.Services.AddScoped<IOptionalCourseEnrollmentRepository, OptionalCourseEnrollmentRepository>();
builder.Services.AddScoped<IPromoCodeRepository, PromoCodeRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ISubjectTaskRepository, SubjectTaskRepository>();
builder.Services.AddScoped<ISupportTicketRepository, SupportTicketRepository>();
builder.Services.AddScoped<ITaskSubmissionRepository, TaskSubmissionRepository>();
builder.Services.AddScoped<IUniversityCourseRepository, UniversityCourseRepository>();

// UnitOfWork (بعد تسجيل كل الريبو)
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// serve wwwroot static files
app.UseStaticFiles();

app.UseRouting();

// IMPORTANT: Authentication before Authorization
app.UseAuthentication();
app.UseAuthorization();

// Map routes (عدل الـ default route لو محتاج)
app.MapControllerRoute(
    name: "default",
    pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

app.Run();
