using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Tables;

namespace Data.Configurations
{
    public class PlayerStatisticConfiguration : IEntityTypeConfiguration<PlayerStatistics>
    {
        public void Configure(EntityTypeBuilder<PlayerStatistics> builder)
        {
            builder.HasKey(ps => new { ps.PlayerId, ps.GameId });

            builder
                .Property(ps => ps.MinutesPlayed)
                .HasColumnType("decimal(10, 2)");


            builder // Many to one - PlayerStatistics to Players
                .HasOne(ps => ps.Player)
                .WithMany(p => p.PlayerStatistics)
                .HasForeignKey(ps => ps.PlayerId);

            builder // Many to one - PlayerStatistics to Games
                .HasOne(ps => ps.Game)
                .WithMany(g => g.PlayerStatistics)
                .HasForeignKey(ps => ps.GameId);

        }
    }
}
