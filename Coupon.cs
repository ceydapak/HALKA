using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace _HALKA
{
    public class Coupon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CouponId { get; set; }
        [Unique]
        public string CouponCode { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public Boolean IsUsed { get; set; }
        public int? UserId { get; set; }
      
    }
}
