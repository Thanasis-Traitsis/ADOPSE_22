using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamGate.Models
{
    public class Option
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OptionId { get; set; }

        [Required]
        public int QuestionId { get; set; }
        public virtual Question question { get; set; }

        [Required]
        public string? OptionText { get; set; }

        public Double Grade {get; set; }// apo ton vathmo tha fainetai an
                                        // h apanthsh einai h swsth h oxi
        
       


    }
}
