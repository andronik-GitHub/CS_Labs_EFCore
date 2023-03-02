using System.ComponentModel.DataAnnotations;

namespace Sales_db.Data.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        public int Quantity { get => Quantity; set { if (value >= 0) Quantity = value; } }
        public decimal Price { get; set; }


        public ICollection<Sales> Sales { get; set; } = new List<Sales>();
    }
}
