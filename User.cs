using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace _HALKA
{
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string? UserName { get; set; } = string.Empty;
        public string? UserLastname { get; set; } = string.Empty;
        public DateTime? Birthdate { get; set; }
        public Boolean? IsStudent { get; set; }
        public string? School { get; set; } = string.Empty;
        public int? Class { get; set; }
        public string? Institution { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? LibraryName { get; set; }
        public string Mail { get; set; } = string.Empty;
        public string? UserImgUrl { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        [JsonIgnore]
        public byte[] PasswordHash { get; set; } = new byte[32];
        [JsonIgnore]
        public byte[] PasswordSalt { get; set; } = new byte[32];
        public string? VerToken { get; set; }
        public DateTime? VAt { get; set; }
        public string? PResetToken { get; set; }
        public DateTime? ResetTokenE { get; set; }
        public int? Score { get; set; }
        public int? TestScore { get; set; }
        public int? CommentScore { get; set; }
        public int? BookPoint { get; set; }
        public string? CouponCode { get; set; }
        
    }
}
