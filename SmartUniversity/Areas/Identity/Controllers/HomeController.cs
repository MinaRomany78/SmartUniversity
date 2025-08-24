using Microsoft.AspNetCore.Mvc;
using Utility.DBInitializer;

namespace SmartUniversity.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identities is null)
            {
                return View();
            }

            if (User.IsInRole($"{SD.UniversityStudent}"))
            {
                return RedirectToAction("index", "UniversityStudent");
            }
            else if (User.IsInRole($"{SD.Doctor}"))
            {
                return RedirectToAction("index", "DoctorAndAssistant");
            }

            else if (User.IsInRole($"{SD.Assistant}"))
            {
                return RedirectToAction("index", "DoctorAndAssistant");
            }
            else if (User.IsInRole($"{SD.ExternalStudent}"))
            {
                return RedirectToAction("index", "ExternalStudent");
            }


            // لو مفيش Role مناسب
            return View();
        }





    }
}

