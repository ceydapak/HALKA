using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace _HALKA
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public string BookName { get; set; } = string.Empty;
        public string Writer { get; set; } = string.Empty;
        public string Publisher { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; }
        public string LibraryName { get; set; }
        public string BookAbout { get; set; } = string.Empty;
        public int BookPoint { get; set; }
        public string BookCategoryName { get; set; }
       
    }
}
