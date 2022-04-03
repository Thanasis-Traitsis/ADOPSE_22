using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ExamGate.Models
{
    public class Option
    {
        [Key]
        public int OptionId { get; set; }
        [Required]
        public string? OptionText { get; set; }
        public Double Vathmos {get; set; }// apo ton vathmo tha fainetai an h apanthsh einai h swsth h oxi
        [Display(Name = "Question")]
        public virtual int QId { get; set; }

        [ForeignKey("QId")]
        public virtual Question? Questions { get; set; }

    }
}
