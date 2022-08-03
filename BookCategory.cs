using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace _HALKA
{
    public class BookCategory
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookCategoryId { get; set; }
        public string BookCategoryName { get; set; }
    
    }
}
