using Hospital_db.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital_db.Data.Configuration
{
    public class DoctorCongifuration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasMany(v => v.Visitations)
                .WithOne(d => d.doctor)
                .HasForeignKey(v => v.DoctorId);
        }
    }
}
