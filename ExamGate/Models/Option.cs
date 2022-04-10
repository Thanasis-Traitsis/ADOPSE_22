using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ExamGate.Models
{
    public class Option
    {
        [Key]
        public int OptionId { get; set; }

        [Required]
        public string? OptionText { get; set; }

        [Range(1, 1000000000000000000,
            ErrorMessage = "Count must be greater than 2")]
        public int optionCount { get; set; }

        public Double Grade {get; set; }// apo ton vathmo tha fainetai an h apanthsh einai h swsth h oxi
        /*[Display(Name = "Question")]
        public virtual int QId { get; set; }
        [ForeignKey("QId")]
        public virtual Question? Questions { get; set; }*/

    }
}
