using BookShop_System.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop_System.Data.Models.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public Guid BookId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(true)]
        public string Title { get; set; } = default!;
        [Required]
        [StringLength(1000)]
        [Unicode(true)]
        public string Description { get; set; } = default!;
        public DateTime? ReleaseDate { get; set; }
        [Required]
        public int Copies { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public EditionType EditionType { get; set; }
        [Required]
        public AgeRestriction AgeRestriction { get; set; }


        public Guid AuthorId { get; set; }
        public Author Author { get; set; } = default!;

        public ICollection<BookCategory> BookCategories { get; set; } = default!;
    }
}
