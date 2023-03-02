namespace Hospital_db.Data.Models
{
    // Багато до багатьох
    public class PatientMedicament
    {
        public int PatientId { get; set; }
        public Patients patient { get; set; } = null!;

        public int MedicamentId { get; set; } // Foreign key
        public Medicaments medicament { get; set; } = null!;
    }
}
