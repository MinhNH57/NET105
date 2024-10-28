using System.ComponentModel.DataAnnotations;

namespace MyAPI.Model
{
    public class SignUpModel
    {
        [Required]
        public string FullName { get; set; } = null!;
        [Required, EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        [Required]
        public string ConfirmPassWord { get; set; } = null!;

    }
}
