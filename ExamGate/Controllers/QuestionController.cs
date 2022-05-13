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
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        //[ValidateAntiForgeryToken ]
        public async Task<IActionResult> Create(QnA q)
        {
            Question qs = new Question();
            qs.QuestionText = q.question.QuestionText;
            qs.Difficulty = q.question.Difficulty;
            qs.Options = new List<Option>();

            foreach (var item in q.option)
            {
                var O = new Option()
                {
                    OptionText = item.OptionText,
                    Grade=item.Grade

                };
                qs.Options.Add(O);

            }

            _db.Question.Add(qs);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
