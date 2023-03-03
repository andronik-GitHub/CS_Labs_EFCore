using System.ComponentModel.DataAnnotations;

namespace Sales_db.Data.Models
{
    public class Sales
    {
        [Key]
        public int SaleId { get; set; }
        public DateTime Date { get; set; }


        public int ProductId { get; set; } // Foreign key
        public Products Product { get; set; } = null!;
        public int CustomerId { get; set; } // Foreign key
        public Customers Customer { get; set; } = null!;
        public int StoreId { get; set; } // Foreign key
        public Stores Store { get; set; } = null!;
    }
}
