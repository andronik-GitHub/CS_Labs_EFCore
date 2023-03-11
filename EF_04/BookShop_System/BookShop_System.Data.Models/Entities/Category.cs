using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop_System.Data.Models.Entities
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; } = default!;


        public ICollection<BookCategory> BookCategories { get; set; } = default!;
    }
}
