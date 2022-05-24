using System;
using Microsoft.AspNetCore.Mvc;
using ExamGate.Data;
using ExamGate.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Threading;

namespace ExamGate.Controllers
{
    public class QuestionController : Controller
    {
        // private readonly Entities _db;


        // public QuestionController(Entities db)
        // {

        //     _db = db;
        // }

        private IQuestionRepository _questionRepository;

        public QuestionController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        public IActionResult Index()
        {
            // IEnumerable<Option> options = _db.Options;
            IEnumerable<Question> questions = _questionRepository.GetAllQuestions();
            //questions = (from q in questions
            //             join o in options on q.QID equals o.QuestionId 
            //             select (q)).Distinct();

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
                    Grade = item.Grade

                };
                qs.Options.Add(O);

            }
            _questionRepository.AddQuestion(qs);
            //_db.SaveChanges();

            return RedirectToAction("Index");
        }
 
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            
           var q =_questionRepository.getQuestionWithOptions(id);
           

            if (q == null)
            {
                return NotFound();
            }
            
            return View(q);
        }

        
        [HttpPost, ActionName("Edit")]
        //[ValidateAntiForgeryToken]
        public async Task <IActionResult> Edit(Question changedQ,IFormCollection collection)
        {  
                
                 _questionRepository.removeChildOptions(changedQ.QuestionId);
                List<string> OptionTextList=collection["o.OptionText"].ToList();
                List<string> GradeList=collection["o.Grade"].ToList();

                //sto parakatw loop prostithontai oi apanthseis pou tha mpoun patwntas to koumpi
                foreach(string item in collection.Keys.Where(k=>k.Contains("OptionText"))){
                    if (item.Any(c => Char.IsDigit(c)))
                    {
                        OptionTextList.Add(collection[item]);
                    }     
                }
                
                foreach(string item in collection.Keys.Where(k=>k.Contains("Grade"))){
                    if (item.Any(c => Char.IsDigit(c)))
                    {
                        GradeList.Add(collection[item]);
                    }
                }

                int i=0;
                changedQ.Options=new List<Option>();
                foreach(var item in OptionTextList){
                   
                    var O = new Option()
                        {
                            OptionText = item,
                            Grade=Convert.ToDouble(GradeList[i])
                            
                        };
                        i++;
                    changedQ.Options.Add(O); 
                
                }
                if(changedQ==null){
                    
                }
             
                if(ModelState.IsValid){
                    _questionRepository.UpdateQuestion(changedQ);
                    TempData["success"] = "Question updated successfully";
                    return RedirectToAction("Index");
                }    
             return View(changedQ);
        }

        public IActionResult Delete(int id)
        {
            
            var QFromDb = _questionRepository.getQuestionWithOptions(id);
            //var categoryFromDbFirst = _db.Categories.FirstOrDefault(u=>u.Id==id);
            //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

            if (QFromDb == null)
            {
                return NotFound();
            }

            return View(QFromDb);
        }

    //POST
    [HttpPost,ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePOST(int id)
    {
        Question obj = _questionRepository.getQuestionWithOptions(id);
        if (obj == null)
        {
            return NotFound();
        }

        _questionRepository.Delete(obj.QuestionId);
            
        TempData["success"] = "Category deleted successfully";
        return RedirectToAction("Index");
        
    }
        

    }
}
