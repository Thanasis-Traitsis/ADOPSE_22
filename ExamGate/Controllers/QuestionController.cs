using Microsoft.AspNetCore.Mvc;
using ExamGate.Data;
using ExamGate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace ExamGate.Controllers
{
    public class QuestionController : Controller
    {
        private readonly ApplicationDbContext _db;

        public QuestionController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(int? i)
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
        [Authorize]
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

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            return View();
        }
        //searching a question by text
        [HttpGet]
        public async Task<IActionResult> Index(string QSearch)
        {
            ViewData["Getquestions"] = QSearch;
            var qsearch = from x in _db.Question select x;
            if(!String.IsNullOrEmpty(QSearch))
            {
                qsearch = qsearch.Where(x => x.QuestionText.Contains(QSearch));
            }
            return View(await qsearch.AsNoTracking().ToListAsync());

        }

        public IActionResult Edit(Question QuestionId)
        {
            return RedirectToAction("Create");
        }

        //delete a question


    }
}
