using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Sales_db.Data.Models
{
    public class Sales
    {
        [Key]
        public Guid SaleId { get; set; }
        public DateTime Date { get; set; }


        public Guid ProductId { get; set; } // Foreign key
        public Products Product { get; set; } = null!;
        public Guid CustomerId { get; set; } // Foreign key
        public Customers Customer { get; set; } = null!;
        public Guid StoreId { get; set; } // Foreign key
        public Stores Store { get; set; } = null!;


        // Для серіалізації та відступу наших даних, щоб добре відображати їх пізніше
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
