using Hospital_db.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital_db.Data.Configuration
{
    public class PatientMedicamentConfiguration : IEntityTypeConfiguration<PatientMedicament>
    {
        public void Configure(EntityTypeBuilder<PatientMedicament> builder)
        {
            builder.HasKey(s => new { s.PatientId, s.MedicamentId });

            builder.HasOne(p => p.patient)
                .WithMany(pm => pm.Prescriptions)
                .HasForeignKey(p => p.PatientId);

            builder.HasOne(m => m.medicament)
                .WithMany(pm => pm.Prescriptions)
                .HasForeignKey(m => m.MedicamentId);
        }
    }
}
