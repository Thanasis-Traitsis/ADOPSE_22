
namespace ExamGate.Models
 
{
    public class Exam
    {
<<<<<<< Updated upstream
=======
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamId { get; set; }

        [Required]
        public string ExamName { get; set; }

        public int QuestionsNumber { get; set; }

        public DateTime CreationDateTime  { get; set; }= DateTime.Now;

        public ICollection<Exam_Question> Exam_Questions { get; set; }
>>>>>>> Stashed changes
    }
}
