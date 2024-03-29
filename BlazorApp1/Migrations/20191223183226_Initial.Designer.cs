﻿// <auto-generated />
using System;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorApp1.Migrations
{
    [DbContext(typeof(UltronContext))]
    [Migration("20191223183226_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorApp1.Models.Fixtures.Awayteam", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamId");

                    b.ToTable("Awayteam");
                });

            modelBuilder.Entity("BlazorApp1.Models.Fixtures.Fixture", b =>
                {
                    b.Property<int>("FixtureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AwayteamTeamId")
                        .HasColumnType("int");

                    b.Property<int>("Elapsed")
                        .HasColumnType("int");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventTimestamp")
                        .HasColumnType("int");

                    b.Property<int?>("FirstHalfStart")
                        .HasColumnType("int");

                    b.Property<int?>("GoalsAwayTeam")
                        .HasColumnType("int");

                    b.Property<int?>("GoalsHomeTeam")
                        .HasColumnType("int");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("Referee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Round")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ScoreId")
                        .HasColumnType("int");

                    b.Property<int?>("SecondHalfStart")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusShort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Venue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FixtureId");

                    b.HasIndex("AwayteamTeamId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("LeagueId");

                    b.HasIndex("ScoreId");

                    b.ToTable("Fixtures");
                });

            modelBuilder.Entity("BlazorApp1.Models.Fixtures.Hometeam", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamId");

                    b.ToTable("Hometeam");
                });

            modelBuilder.Entity("BlazorApp1.Models.Fixtures.League", b =>
                {
                    b.Property<int>("LeagueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LeagueId");

                    b.ToTable("League");
                });

            modelBuilder.Entity("BlazorApp1.Models.Fixtures.Score", b =>
                {
                    b.Property<int>("ScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Extratime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fulltime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Halftime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Penalty")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ScoreId");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("BlazorApp1.Models.Fixtures.Fixture", b =>
                {
                    b.HasOne("BlazorApp1.Models.Fixtures.Awayteam", "Awayteam")
                        .WithMany()
                        .HasForeignKey("AwayteamTeamId");

                    b.HasOne("BlazorApp1.Models.Fixtures.Hometeam", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorApp1.Models.Fixtures.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorApp1.Models.Fixtures.Score", "Score")
                        .WithMany()
                        .HasForeignKey("ScoreId");
                });
#pragma warning restore 612, 618
        }
    }
}
