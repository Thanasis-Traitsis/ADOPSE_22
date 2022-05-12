using Microsoft.AspNetCore.Mvc;
using ExamGate.Data;
using ExamGate.Models;

namespace ExamGate.Controllers
{
    public class QuestionController : Controller
    {
        private readonly ApplicationDbContext _db;

        public QuestionController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Question> questions = _db.Question;
            return View(questions);
        }



        [HttpGet]
        public IActionResult Question()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> QuestionAsync(Question obj)
        {
            if (ModelState.IsValid)
            {
                _db.Question.Add(obj);
                _db.SaveChanges();
                await Task.CompletedTask;
                TempData["success"] = "Question created successfully";
                return RedirectToAction("Index");
            }

            return RedirectToAction("Question");
        }

        
}
}
