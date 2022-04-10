using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamGate.Models
{   /*apothkeuei dedomena gia tis prospatheies
     * pou exoun ginei panw se ena exam */
    public class Try
    {
        [Key]

        public int TryId { get; set; }

        public DateTime SubmissionDateTime { get; set; } = DateTime.Now;
        /*Ena exam mporei na dothei perissoteres
        * apo mia fores kai mesw tou sun8etou kleidiou
        * Id kai DateTime auto pragmatopoieitai*/
        [Required]
        [Display(Name = "User")]
        public virtual int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User? Users { get; set; }

        [Display(Name = "Exam")]
        public virtual int ExamId { get; set; }

        [ForeignKey("ExamId")]
        public virtual Exam? Exams { get; set; }

        
        [Required]
        [Range(0.0,10.0,ErrorMessage ="Grade should be from 0.0 to 10.0")]
        public double FinalGrade { get; set; }

    }
}
