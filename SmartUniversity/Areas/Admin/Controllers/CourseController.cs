using DataAccess.Data;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace SmartUniversity.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Course
        public IActionResult Index()
        {
            var courses = _context.UniversityCourses.ToList();
            return View(courses);
        }

        // GET: Admin/Course/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UniversityCourse course)
        {
            if (ModelState.IsValid)
            {
                _context.UniversityCourses.Add(course);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // GET: Admin/Course/Edit/5
        public IActionResult Edit(int id)
        {
            var course = _context.UniversityCourses.Find(id);
            if (course == null) return NotFound();
            return View(course);
        }

        // POST: Admin/Course/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, UniversityCourse course)
        {
            if (id != course.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.UniversityCourses.Update(course);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // GET: Admin/Course/Delete/5
        public IActionResult Delete(int id)
        {
            var course = _context.UniversityCourses.Find(id);
            if (course == null) return NotFound();
            return View(course);
        }

        // POST: Admin/Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var course = _context.UniversityCourses.Find(id);
            if (course == null) return NotFound();

            _context.UniversityCourses.Remove(course);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
