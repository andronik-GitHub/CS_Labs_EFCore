using System.ComponentModel.DataAnnotations;

namespace Sales_db.Data.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [MaxLength(80)]
        public string Email { get; set; } = null!;
        public string CreaditCardNumber { get; set; } = null!;


        public ICollection<Sales> Sales { get; set; } = new List<Sales>();
    }
}
