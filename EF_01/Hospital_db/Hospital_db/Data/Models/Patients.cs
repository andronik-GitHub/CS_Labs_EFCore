using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Hospital_db.Data.Models
{
    public class Patients
    {
        [Key]
        public int PatientId { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;
        [MaxLength(50)]
        public string LastName { get; set; } = null!;
        [MaxLength(250)]
        public string Address { get; set; } = null!;
        [MaxLength(80)]
        public string Email { get; set; } = null!;
        public bool HasInsurance { get; set; }


        public ICollection<Visitations> Visitations { get; set; } = new List<Visitations>();
        public ICollection<Diagnoses> Diagnoses { get; set; } = new List<Diagnoses>();
        public ICollection<PatientMedicament> Prescriptions { get; set; } = new List<PatientMedicament>();
    }
}
