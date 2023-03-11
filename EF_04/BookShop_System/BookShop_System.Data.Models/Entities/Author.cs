using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop_System.Data.Models.Entities
{
    [Table("Authors")]
    public class Author
    {
        [Key]
        public Guid AuthorId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(true)]
        public string FirtsName { get; set; } = default!;
        [Required]
        [StringLength(50)]
        [Unicode(true)]
        public string LastName { get; set; } = default!;


        public ICollection<Book> Books { get; set; } = default!;
    }
}
