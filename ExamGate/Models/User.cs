using System.ComponentModel.DataAnnotations;

namespace ExamGate.Models
{
    public class User
    {
        [Key]
        int UserId { get; set; }
        [Required]
        String? UserName { get; set; }
        [Required]
        String? UserEmail { get; set; }

    }
}
