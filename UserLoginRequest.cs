using System.ComponentModel.DataAnnotations;

namespace _HALKA
{
    public class UserLoginRequest
    {

        [Required, EmailAddress]
        public string Mail { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
