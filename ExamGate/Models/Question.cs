using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ExamGate.Models
{
    public class Question
    {
        [Key]
        int QuestionId { get; set; }
        [Required]
        String? QuestionText { get; set; }
        [Required]
        [Display(Name = "Option")]
        public virtual int OptionId { get; set; }

        [ForeignKey("OptionId")]
        public virtual Option? Options { get; set; }
    }
}
