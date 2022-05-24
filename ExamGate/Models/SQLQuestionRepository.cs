using Microsoft.AspNetCore.Mvc;
using ExamGate.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using NuGet.Packaging;
using System.Collections.Generic;

namespace ExamGate.Models
{
    public class SQLQuestionRepository:IQuestionRepository
    {
        private readonly ApplicationDbContext context;

        public SQLQuestionRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Question AddQuestion(Question question)
        {
            context.Question.Add(question);
            context.SaveChanges();
            return question;
        }

        public Question Delete(int Id)
        {
            Question question = context.Question.Find(Id);
            if (question != null)
            {
                context.Question.Remove(question);
                context.SaveChanges();
            }
            return question;
        }

        public IEnumerable<Question> GetAllQuestions()
        {
            return context.Question;
        }
        public List<Option> GetAllOptions()
        {
            return context.Option.ToList();
        }

        public Question GetQuestion(int Id)
        {
            return context.Question.Find(Id);
        }
        public void SetNewValuesOnQuestion(Question oldValues,Question newValues){
            context.Entry(oldValues).CurrentValues.SetValues(newValues);
        }
        public Question UpdateQuestion(Question questionChanges)
        {
            var Question = context.Question.Attach(questionChanges);
            Question.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return questionChanges;
        }
        
        public void removeChildOptions(int qid){
            List<Option> allOptions=context.Option.ToList();
            foreach(Option item in allOptions){
                if(item.QuestionId==qid){
                    context.Option.Remove(item);
                    //context.SaveChanges();
                }
            }
            
        }

        public Question getQuestionWithOptions(int id){
            return context.Question.Include(i => i.Options)
                    .Where(i => i.QuestionId == id)
                    .Single();
        }

        public List<Option> getAllOptionsByQuestionId(int id){
            List<Option> getOptions=new List<Option>();
            foreach(Option item in context.Option){
                if(item.QuestionId==id){
                    getOptions.Add(item);
                }
            }
            return getOptions;
        }
        
        public Option UpdateOption(Option optionToUpdate){
            var Option = context.Option.Attach(optionToUpdate);
            Option.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //context.SaveChanges();
            return optionToUpdate;
        }

        public void SetNewValuesOnOption(Option oldValues,Option newValues){
            context.Entry(oldValues).CurrentValues.SetValues(newValues);
        }

        public Option FindOption(Question relatedQ,int optionId){
                
                return context.Option.Include(i => i.question)
                .Where(i => i.OptionId ==optionId&&i.QuestionId==relatedQ.QuestionId)
                .Single();
        }
        
    }
}