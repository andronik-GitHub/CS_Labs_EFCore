using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Tables;

namespace Data.Configurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Players>
    {
        public void Configure(EntityTypeBuilder<Players> builder)
        {
            builder // Many to one - Players to Positions
                .HasOne(p => p.Position)
                .WithMany(p => p.Players)
                .HasForeignKey(p => p.PositionId);

            builder // Many to one - Players to Teams
                .HasOne(p => p.Team)
                .WithMany(t => t.Players)
                .HasForeignKey(p => p.TeamId);

            builder // One to many - Players to PlayerStatistics
                .HasMany(p => p.PlayerStatistics)
                .WithOne(ps => ps.Player)
                .HasForeignKey(ps => ps.PlayerId);
        }
    }
}
