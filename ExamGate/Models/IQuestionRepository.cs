



namespace ExamGate.Models
{
    public interface IQuestionRepository
    {
        Question GetQuestion(int id);
        IEnumerable<Question> GetAllQuestions();
        List<Option> GetAllOptions();
        Question AddQuestion(Question question);
        Question UpdateQuestion(Question questionChanges);
        Question Delete(int id); 
        void removeChildOptions(int questionId);
        Question getQuestionWithOptions(int id);
        List<Option> getAllOptionsByQuestionId(int id);
        Option UpdateOption(Option option);
        void SetNewValuesOnOption(Option oldValues,Option newValues);
        void SetNewValuesOnQuestion(Question oldValues,Question newValues);
        Option FindOption(Question relatedQ,int optionId);
        
    }
}