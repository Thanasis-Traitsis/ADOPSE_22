using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamGate.Models
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionId { get; set; }
        [Required]
        public String? QuestionText { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 10, ErrorMessage = "Dif. level should be from 1 to 10")]
        public int Difficulty { get; set; }

    }
}
