using Hospital_db.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital_db.Data.Configuration
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patients>
    {
        public void Configure(EntityTypeBuilder<Patients> builder)
        {
            builder.HasMany(v => v.Visitations)
                .WithOne(v => v.patient)
                .HasForeignKey(v => v.PatiendId);

            builder.HasMany(d => d.Diagnoses)
                .WithOne(d => d.patient)
                .HasForeignKey(d => d.PatiendId);
        }
    }
}
