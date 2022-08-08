using System.ComponentModel.DataAnnotations;

namespace _HALKA
{
    public class ResetPassRequest
    {
        [Required]
        public string Token { get; set; } = string.Empty;
        [Required, MinLength(6)]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
