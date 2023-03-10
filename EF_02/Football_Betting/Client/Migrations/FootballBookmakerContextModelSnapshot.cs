﻿// <auto-generated />
using System;
using Data.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Client.Migrations
{
    [DbContext(typeof(FootballBookmakerContext))]
    partial class FootballBookmakerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Tables.Bets", b =>
                {
                    b.Property<Guid>("BetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18, 5)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Prediction")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BetId");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Bets");
                });

            modelBuilder.Entity("Models.Tables.Colors", b =>
                {
                    b.Property<Guid>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Models.Tables.Countries", b =>
                {
                    b.Property<Guid>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Models.Tables.Games", b =>
                {
                    b.Property<Guid>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("AwayTeamBetRate")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("AwayTeamGoals")
                        .HasColumnType("int");

                    b.Property<Guid>("AwayTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DrawBetRate")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<decimal>("HomeTeamBetRate")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("HomeTeamGoals")
                        .HasColumnType("int");

                    b.Property<Guid>("HomeTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.HasKey("GameId");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Models.Tables.PlayerStatistics", b =>
                {
                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Assists")
                        .HasColumnType("bit");

                    b.Property<decimal>("MinutesPlayed")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("ScoredGoals")
                        .HasColumnType("int");

                    b.HasKey("PlayerId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("PlayerStatistics");
                });

            modelBuilder.Entity("Models.Tables.Players", b =>
                {
                    b.Property<Guid>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsInjured")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PositionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SquadNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlayerId");

                    b.HasIndex("PositionId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Models.Tables.Positions", b =>
                {
                    b.Property<Guid>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Models.Tables.Teams", b =>
                {
                    b.Property<Guid>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18, 5)");

                    b.Property<int>("Initials")
                        .HasColumnType("int");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PrimaryKitColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SecondaryKitColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TownId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TeamId");

                    b.HasIndex("PrimaryKitColorId");

                    b.HasIndex("SecondaryKitColorId");

                    b.HasIndex("TownId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Models.Tables.Towns", b =>
                {
                    b.Property<Guid>("TownId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TownId");

                    b.HasIndex("CountryId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("Models.Tables.Users", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18, 5)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Models.Tables.Bets", b =>
                {
                    b.HasOne("Models.Tables.Games", "Game")
                        .WithMany("Bets")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Tables.Users", "User")
                        .WithMany("Bets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Tables.Games", b =>
                {
                    b.HasOne("Models.Tables.Teams", "AwayTeam")
                        .WithMany("Games_AwayTeam")
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Models.Tables.Teams", "HomeTeam")
                        .WithMany("Games_HomeTeam")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");
                });

            modelBuilder.Entity("Models.Tables.PlayerStatistics", b =>
                {
                    b.HasOne("Models.Tables.Games", "Game")
                        .WithMany("PlayerStatistics")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Tables.Players", "Player")
                        .WithMany("PlayerStatistics")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Models.Tables.Players", b =>
                {
                    b.HasOne("Models.Tables.Positions", "Position")
                        .WithMany("Players")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Tables.Teams", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Models.Tables.Teams", b =>
                {
                    b.HasOne("Models.Tables.Colors", "PrimaryKitColor")
                        .WithMany("Teams_PrimaryKitColor")
                        .HasForeignKey("PrimaryKitColorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Models.Tables.Colors", "SecondaryKitColor")
                        .WithMany("Teams_SecondaryKitColor")
                        .HasForeignKey("SecondaryKitColorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Models.Tables.Towns", "Town")
                        .WithMany("Teams")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PrimaryKitColor");

                    b.Navigation("SecondaryKitColor");

                    b.Navigation("Town");
                });

            modelBuilder.Entity("Models.Tables.Towns", b =>
                {
                    b.HasOne("Models.Tables.Countries", "Country")
                        .WithMany("Towns")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Models.Tables.Colors", b =>
                {
                    b.Navigation("Teams_PrimaryKitColor");

                    b.Navigation("Teams_SecondaryKitColor");
                });

            modelBuilder.Entity("Models.Tables.Countries", b =>
                {
                    b.Navigation("Towns");
                });

            modelBuilder.Entity("Models.Tables.Games", b =>
                {
                    b.Navigation("Bets");

                    b.Navigation("PlayerStatistics");
                });

            modelBuilder.Entity("Models.Tables.Players", b =>
                {
                    b.Navigation("PlayerStatistics");
                });

            modelBuilder.Entity("Models.Tables.Positions", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("Models.Tables.Teams", b =>
                {
                    b.Navigation("Games_AwayTeam");

                    b.Navigation("Games_HomeTeam");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("Models.Tables.Towns", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Models.Tables.Users", b =>
                {
                    b.Navigation("Bets");
                });
#pragma warning restore 612, 618
        }
    }
}
