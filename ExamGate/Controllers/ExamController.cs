using Microsoft.AspNetCore.Mvc;

namespace ExamGate.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
