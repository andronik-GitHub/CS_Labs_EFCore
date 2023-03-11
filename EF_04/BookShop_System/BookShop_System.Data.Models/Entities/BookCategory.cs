using System.ComponentModel.DataAnnotations;

namespace BookShop_System.Data.Models.Entities
{
    public class BookCategory
    {
        [Key]
        public Guid BookId { get; set; }
        public Book Book { get; set; } = default!;

        [Key]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
