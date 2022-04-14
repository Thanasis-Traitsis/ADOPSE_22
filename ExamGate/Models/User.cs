using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ExamGate.Models
{
    public class User : IdentityUser
    {
        
        [Key]
        [PersonalData]
        public override string? Id { get; set; }

        [Required]
        [PersonalData]
        [MaxLength(100)]
        public String? FirstName { get; set; }

        [Required]
        [PersonalData]
        [MaxLength (100)]
        public override String? Email { get; set; }

        [PersonalData]
        [Required]
        [MaxLength(255)]
        [DataType(DataType.Password)]
        public String? Password { get; set; }

        [PersonalData]
        public Boolean Admin { get; set; }
        [PersonalData]
        public Boolean EndUser { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }


    }
}
