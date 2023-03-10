using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Tables;

namespace Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Countries>
    {
        public void Configure(EntityTypeBuilder<Countries> builder)
        {
            builder // One to many - Countries to Towns
                .HasMany(c => c.Towns)
                .WithOne(t => t.Country)
                .HasForeignKey(t => t.CountryId);
        }
    }
}
