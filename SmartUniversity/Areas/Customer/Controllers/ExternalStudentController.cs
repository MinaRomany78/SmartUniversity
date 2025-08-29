using DataAccess.Repositories.IRepositories;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmartUniversity.Areas.Customer.Controllers
{
    [Area ("Customer")]
    public class  ExternalStudentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExternalStudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var Courses = await _unitOfWork.OptionalCourses.GetAsync(include : new Expression<Func<OptionalCourse, object>>[]
            {
                e => e.Instructor,
                e => e.Instructor.ApplicationUser
            });

            return View(Courses);
        }
    }
}
