using System.ComponentModel.DataAnnotations;

namespace Telefin.Models
{
    public class CreateAccountModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string PhoneNo1 { get; set; }

        public string PhoneNo2 { get; set; }

        [Required]
        public string DOB { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PasswordRewrite { get; set; }
    }
}