using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Sales_db.Data.Models
{
    public class Customers
    {
        [Key]
        public Guid CustomerId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = default!;
        [MaxLength(80)]
        public string Email { get; set; } = default!;
        public string CreaditCardNumber { get; set; } = default!;


        public ICollection<Sales> Sales { get; set; } = new List<Sales>();


        // Для серіалізації та відступу наших даних, щоб добре відображати їх пізніше
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
