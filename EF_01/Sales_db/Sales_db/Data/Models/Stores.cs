using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Sales_db.Data.Models
{
    public class Stores
    {
        [Key]
        public Guid StoreId { get; set; }
        [MaxLength(80)]
        public string Name { get; set; } = string.Empty;


        public ICollection<Sales> Sales { get; set; } = new List<Sales>();


        // Для серіалізації та відступу наших даних, щоб добре відображати їх пізніше
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
