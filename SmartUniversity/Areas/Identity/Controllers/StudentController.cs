using Microsoft.AspNetCore.Mvc;

namespace SmartUniversity.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class StudentController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet]
        public IActionResult NationalId() {
            return View();
        }
        [HttpPost]
        public IActionResult NationalId(string NationalId)
        {
            return View();

        }

    }
}
