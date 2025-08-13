using Microsoft.AspNetCore.Mvc;

namespace SmartUniversity.Areas.Customer.Controllers
{
    public class UniversityStudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
