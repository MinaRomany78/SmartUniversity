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
            var courses = await _unitOfWork.UniversityCourses.GetAsync(
                include: new Expression<Func<UniversityCourse, object>>[]
                {
                    e => e.Department,
                    e => e.Term
                });
            courses=courses.Skip(0).Take(10).ToList();
            return View(courses);
        }
    }
}
