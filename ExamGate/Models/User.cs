using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamGate.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
<<<<<<< Updated upstream

        [Required]
        [MaxLength(100)]
        public String? UserName { get; set; }

        [Required]
        [MaxLength (100)]
        public String? UserEmail { get; set; }

        [Required]
        [MaxLength(255)]
        [DataType(DataType.Password)]
        public String? Password { get; set; }


        public Boolean Admin { get; set; }
        public Boolean EndUser { get; set; }


=======
        [Required]
        public String? UserName { get; set; }
        [Required]
        public String? UserEmail { get; set; }
>>>>>>> Stashed changes

    }
}
