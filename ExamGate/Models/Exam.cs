using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamGate.Models
 
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }

        [Required]
        [Display(Name = "Question")]
        public virtual int QId { get; set; }

        [ForeignKey("QId")]
        public virtual Question? Questions { get; set; }

        public int QuestionNumber { get; set; }

        [Display(Name = "User")]
        public virtual int UserId { get; set; }

        [ForeignKey("Id")]
        public virtual User? Users { get; set; }

        [Display(Name = "Subject")]
        public virtual int SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject? Subjects { get; set; }

        public DateTime CreationDateTime  { get; set; }= DateTime.Now;





    }
}
