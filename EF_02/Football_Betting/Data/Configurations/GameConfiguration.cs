using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Tables;

namespace Data.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Games>
    {
        public void Configure(EntityTypeBuilder<Games> builder)
        {
            builder
                .Property(g => g.HomeTeamBetRate)
                .HasColumnType("decimal(5, 2)");

            builder
                .Property(g => g.AwayTeamBetRate)
                .HasColumnType("decimal(5, 2)");

            builder
                .Property(g => g.DrawBetRate)
                .HasColumnType("decimal(5, 2)");


            builder // One to many - Games to PlayerStatistics
                .HasMany(g => g.PlayerStatistics)
                .WithOne(ps => ps.Game)
                .HasForeignKey(ps => ps.GameId);

            builder // One to many - Games to Bets
                .HasMany(g => g.Bets)
                .WithOne(b => b.Game)
                .HasForeignKey(b => b.GameId);

            builder // Many to one - Games to Teams
                .HasOne(g => g.HomeTeam)
                .WithMany(t => t.Games_HomeTeam)
                .HasForeignKey(g => g.HomeTeamId)
                .OnDelete(DeleteBehavior.NoAction);

            builder // Many to one - Games to Teams
                .HasOne(g => g.AwayTeam)
                .WithMany(t => t.Games_AwayTeam)
                .HasForeignKey(g => g.AwayTeamId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
