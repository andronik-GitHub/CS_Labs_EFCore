using System.ComponentModel.DataAnnotations;

namespace Hospital_db.Data.Models
{
    public class Medicaments
    {
        [Key]
        public int MedicamentId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        public ICollection<PatientMedicament> Prescriptions { get; set; } = new List<PatientMedicament>();
    }
}
