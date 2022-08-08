using System.ComponentModel.DataAnnotations;

namespace _HALKA
{
    public class UserRegisterRequest
    {
        public string? UserName { get; set; } = string.Empty;
        public string? UserLastname { get; set; } = string.Empty;
        public DateTime? Birthdate { get; set; }
        public Boolean? IsStudent { get; set; }
        public string? School { get; set; } = string.Empty;
        public int? Class { get; set; }
        public string? Institution { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? LibraryName { get; set; }
        [Required, EmailAddress]
        public string Mail { get; set; } = string.Empty;
        [Required, MinLength(6)]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
