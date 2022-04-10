using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamGate.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        [Required]
        public String? QuestionText { get; set; }

        [Range(minimum: 1, maximum: 10, ErrorMessage = "Dif. level should be from 1 to 10")]
        public int Difficulty { get; set; }

        [Required]
        [Range(minimum:2 ,maximum:100000,ErrorMessage = "Options must be more than 2")]
        [Display(Name = "Option")]
        public virtual int OptionId { get; set; }

        [ForeignKey("OptionId")]
        public virtual Option? Options { get; set; }
    }
}
