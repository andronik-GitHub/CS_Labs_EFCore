using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Tables;

namespace Data.Configurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Colors>
    {
        public void Configure(EntityTypeBuilder<Colors> builder)
        {
            builder // One to many - Colors to Teams
                .HasMany(t => t.Teams_PrimaryKitColor)
                .WithOne(p => p.PrimaryKitColor)
                .HasForeignKey(p => p.PrimaryKitColorId);

            builder // One to many - Colors to Teams
                .HasMany(t => t.Teams_SecondaryKitColor)
                .WithOne(p => p.SecondaryKitColor)
                .HasForeignKey(p => p.SecondaryKitColorId);
        }
    }
}
