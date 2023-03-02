using System.ComponentModel.DataAnnotations;

namespace Sales_db.Data.Models
{
    public class Stores
    {
        [Key]
        public int StoreId { get; set; }
        [MaxLength(80)]
        public string Name { get; set; } = null!;


        public ICollection<Sales> Sales { get; set; } = new List<Sales>();
    }
}
