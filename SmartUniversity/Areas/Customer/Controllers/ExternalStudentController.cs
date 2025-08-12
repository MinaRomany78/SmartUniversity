using Microsoft.AspNetCore.Mvc;

namespace SmartUniversity.Areas.Customer.Controllers
{
    public class  ExternalStudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
