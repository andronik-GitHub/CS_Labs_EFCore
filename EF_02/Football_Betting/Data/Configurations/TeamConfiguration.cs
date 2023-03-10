using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Tables;

namespace Data.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Teams>
    {
        public void Configure(EntityTypeBuilder<Teams> builder)
        {
            builder
                .Property(t => t.Budget)
                .HasColumnType("decimal(18, 5)");


            builder // Many to one - Teams to Colors
                .HasOne(t => t.PrimaryKitColor)
                .WithMany(c => c.Teams_PrimaryKitColor)
                .HasForeignKey(t => t.PrimaryKitColorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder // Many to one - Teams to Colors
                .HasOne(t => t.SecondaryKitColor)
                .WithMany(c => c.Teams_SecondaryKitColor)
                .HasForeignKey(t => t.SecondaryKitColorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder // Many to one - Teams to Towns  
                .HasOne(t => t.Town)
                .WithMany(t => t.Teams)
                .HasForeignKey(t => t.TownId);

            builder // One to many - Teams to Players
                .HasMany(t => t.Players)
                .WithOne(p => p.Team)
                .HasForeignKey(p => p.TeamId);

            builder // One to many - Teams to Games
                .HasMany(t => t.Games_HomeTeam)
                .WithOne(p => p.HomeTeam)
                .HasForeignKey(p => p.HomeTeamId);

            builder // One to many - Teams to Games
                .HasMany(t => t.Games_AwayTeam)
                .WithOne(p => p.AwayTeam)
                .HasForeignKey(p => p.AwayTeamId);
        }
    }
}
