using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Tables;

namespace Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder
                .Property(u => u.Balance)
                .HasColumnType("decimal(18, 5)");


            builder // One to many - Users to Bets
                .HasMany(u => u.Bets)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.UserId);
        }
    }
}
