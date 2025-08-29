
using DataAccess.Repositories.IRepositories;
using Entities.Models;
using Entities.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmartUniversity.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class UniversityStudentController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;

        public UniversityStudentController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {

            return View();
        }
        public async Task<IActionResult> RegisterCourses()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return NotFound();
            var student = await _unitOfWork.Students.GetOneAsync(e => e.ApplicationUserId == user.Id);
            if (student == null)
                return NotFound();
            var courses = await _unitOfWork.UniversityCourses.GetAsync(
                e => e.TermId == student.TermId && e.DepartmentID == student.DepartmentID
            );
            var registered = await _unitOfWork.Enrollments.GetAsync(e => e.StudentID == student.Id);
            var registeredIds = registered.Select(e => e.UniversityCourseID).ToList();
            var vm = courses.Select(c => new RegisterCoursesVM
            {
                CourseId = c.Id,
                Name = c.Name,
                Credits = c.CreditHours,
                IsSelected=registeredIds.Contains(c.Id)
               
            }).ToList();

            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> RegisterCourses(List<int> SelectedCourses)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound();

            var student = await _unitOfWork.Students.GetOneAsync(s => s.ApplicationUserId == user.Id);
            if (student == null) return NotFound();

            if (SelectedCourses == null || !SelectedCourses.Any())
            {
                TempData["error-notification"]="Please select at least courses the sum credit hours =15.";
                return RedirectToAction(nameof(RegisterCourses));
            }

            var registered = await _unitOfWork.Enrollments.GetAsync(e => e.StudentID == student.Id);
            int alreadyRegisteredCredits = registered.Sum(e => e.CreditHours);

            var courses = await _unitOfWork.UniversityCourses.GetAsync(c => SelectedCourses.Contains(c.Id));
            int newCredits = courses.Sum(c => c.CreditHours);

            int totalCredits = alreadyRegisteredCredits + newCredits;

            if (totalCredits < 15 || totalCredits > 18)
            {
                TempData["error-notification"] = "You must register between 15 and 18 credit hours in total.";
                return RedirectToAction(nameof(RegisterCourses));
            }


            foreach (var course in courses)
            {
                var already = await _unitOfWork.Enrollments.GetOneAsync(
                    e => e.StudentID == student.Id && e.UniversityCourseID == course.Id
                );
                if (already != null) 
                
                {
                    TempData["error-notification"] = "this Course Already Register.";
                    return RedirectToAction(nameof(RegisterCourses));


                }


                var enrollment = new Enrollment
                {
                    StudentID = student.Id,
                    UniversityCourseID = course.Id,
                    EnrollmentDate = DateTime.Now,
                    IsPaid = false,
                    Term = course.Term?.Name ?? "N/A",
                    CreditHours = course.CreditHours
                };

                await _unitOfWork.Enrollments.CreateAsync(enrollment);
            }
            return RedirectToAction("MyCourses");
        }

        public async Task<IActionResult> MyCourses()
        {


            var user = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound();

            var student = await _unitOfWork.Students.GetOneAsync(s => s.ApplicationUserId == user.Id);
            if (student == null) return NotFound();

            var enrollments = await _unitOfWork.Enrollments.GetAsync(e => e.StudentID == student.Id,include: new Expression<Func<Enrollment, object>>[]{ 
                e=>e.UniversityCourse
            });

            var vm = enrollments.Select(e => new RegisterCoursesVM
            {
                CourseId = e.UniversityCourseID,
                Name = e.UniversityCourse.Name,
                Credits = e.CreditHours,
            }).ToList();

            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Unregister(int courseId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound();

            var student = await _unitOfWork.Students.GetOneAsync(s => s.ApplicationUserId == user.Id);
            if (student == null) return NotFound();

            var enrollment = await _unitOfWork.Enrollments.GetOneAsync(
                e => e.StudentID == student.Id && e.UniversityCourseID == courseId
            );

            if (enrollment != null)
            {
               await _unitOfWork.Enrollments.DeleteAsync(enrollment);
               

                TempData["success-notification"] = "Course unregistered successfully.";
            }
            else
            {
                TempData["error-notification"] = "Course not found in your registration.";
            }

            return RedirectToAction(nameof(MyCourses));
        }




    }
}
