using DataAccess.Data;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SmartUniversity.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customer/Course
        public IActionResult Index()
        {
            var courses = _context.UniversityCourses
                .Include(c => c.Enrollments) // علشان نعرض عدد المسجلين مثلاً
                .ToList();

            return View(courses);
        }

        // GET: Customer/Course/Details/5
        public IActionResult Details(int id)
        {
            var course = _context.UniversityCourses
                .Include(c => c.Enrollments)
                .ThenInclude(e => e.Student)
                .FirstOrDefault(c => c.Id == id);

            if (course == null) return NotFound();

            return View(course);
        }

        // تسجيل طالب في كورس (مرتبط بالـ ERD)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Enroll(int courseId)
        {
            // مؤقتاً هنخلي StudentID = 1 (لحد ما نربطه بالـ Identity/Login)
            int studentId = 1;

            var course = _context.UniversityCourses.Find(courseId);
            if (course == null) return NotFound();

            // نتأكد إن الطالب مش مسجل قبل كده
            var existing = _context.Enrollments
                .FirstOrDefault(e => e.StudentID == studentId && e.UniversityCourseID == courseId);

            if (existing != null)
            {
                TempData["Message"] = "You are already enrolled in this course.";
                return RedirectToAction(nameof(Details), new { id = courseId });
            }

            var enrollment = new Enrollment
            {
                StudentID = studentId,
                UniversityCourseID = courseId,
                EnrollmentDate = DateTime.Now,
                IsPaid = false,
                Term = course.Term,
                CreditHours = course.CreditHours
            };

            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();

            TempData["Message"] = "Enrolled successfully!";
            return RedirectToAction(nameof(Details), new { id = courseId });
        }
    }
}
