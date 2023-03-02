using System.ComponentModel.DataAnnotations;

namespace Hospital_db.Data.Models
{
    public class Patients
    {
        [Key]
        public int PatientId { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(80)]
        public string Email { get; set; }
        public bool HasInsurance { get; set; }


        public ICollection<Visitations> Visitations { get; set; }
        public ICollection<Diagnoses> Diagnoses { get; set; }
        public ICollection<PatientMedicament> Prescriptions { get; set; }
    }
}
