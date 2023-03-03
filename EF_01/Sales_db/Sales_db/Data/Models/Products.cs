using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sales_db.Data.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public int Quantity { get => Quantity; set { if (value >= 0) Quantity = value; } }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        public ICollection<Sales> Sales { get; set; } = new List<Sales>();
    }
}
