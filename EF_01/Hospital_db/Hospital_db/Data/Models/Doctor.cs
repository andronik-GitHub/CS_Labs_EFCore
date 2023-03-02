using System.ComponentModel.DataAnnotations;

namespace Hospital_db.Data.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;
        [MaxLength(100)]
        public string LastName { get; set; } = null!;
        [MaxLength(100)]
        public string Specialty { get; set; } = null!;


        public ICollection<Visitations> Visitations { get; set; } = new List<Visitations>();
    }
}
