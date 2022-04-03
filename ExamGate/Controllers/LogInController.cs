using Microsoft.AspNetCore.Mvc;

namespace ExamGate.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }
    }
}
