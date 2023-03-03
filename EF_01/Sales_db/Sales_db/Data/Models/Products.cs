using Sales_db.Data.Bogus;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Sales_db.Data.Models
{
    public class Products
    {
        [Key]
        public Guid ProductId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        [NotMapped]
        public Personality Personality { get; set; }
        public ICollection<Sales> Sales { get; set; } = new List<Sales>();


        // Для серіалізації та відступу наших даних, щоб добре відображати їх пізніше
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
