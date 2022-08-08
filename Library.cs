using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace _HALKA
{
    public class Library
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LibraryId { get; set; }
        public string LibraryName { get; set; } = string.Empty;
        public string? LibraryLocation { get; set; } = string.Empty;
        public string? LibraryStaff { get; set; } = string.Empty;
        public string? LibraryPhone { get; set; } = string.Empty;
        public string? LibraryMail { get; set; } = string.Empty;
        public string? LibraryImgUrl { get; set; }= string.Empty;
    }
}
