﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trabalho.Data;

namespace Trabalho.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200103230846_AddAccount")]
    partial class AddAccount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Trabalho.Models.Champion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AbilitiesId")
                        .HasColumnType("int");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<string>("Lore")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("AbilitiesId");

                    b.ToTable("Champions");
                });

            modelBuilder.Entity("Trabalho.Models.ChampionAbilities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("E")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Passive")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Q")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("R")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("W")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("ChampionsAbilities");
                });

            modelBuilder.Entity("Trabalho.Models.IngameAccount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<int>("QuickStatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuickStatId");

                    b.ToTable("IngameAccount");
                });

            modelBuilder.Entity("Trabalho.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Gold")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("MatchPlayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchPlayerId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Trabalho.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GameType")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("TeamBlueId")
                        .HasColumnType("int");

                    b.Property<int>("TeamRedId")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("WinnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamBlueId");

                    b.HasIndex("TeamRedId");

                    b.HasIndex("WinnerId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Trabalho.Models.MatchPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<int>("ChampionId")
                        .HasColumnType("int");

                    b.Property<int>("Deaths")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("Gold")
                        .HasColumnType("int");

                    b.Property<float>("Kda")
                        .HasColumnType("float");

                    b.Property<int>("Kills")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ChampionId");

                    b.HasIndex("GameId");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("MatchPlayers");
                });

            modelBuilder.Entity("Trabalho.Models.MatchTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Objectives")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("TotalGold")
                        .HasColumnType("int");

                    b.Property<long?>("User1Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("User2Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("User3Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("User4Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("User5Id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("User1Id");

                    b.HasIndex("User2Id");

                    b.HasIndex("User3Id");

                    b.HasIndex("User4Id");

                    b.HasIndex("User5Id");

                    b.ToTable("MatchTeams");
                });

            modelBuilder.Entity("Trabalho.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<string>("Token")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Trabalho.Models.UserQuickStat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("HighestWinRateChamp")
                        .HasColumnType("int");

                    b.Property<int>("MainChampId")
                        .HasColumnType("int");

                    b.Property<string>("RankFlex")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RankSolo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("MainChampId");

                    b.ToTable("UsersQuickStat");
                });

            modelBuilder.Entity("Trabalho.Models.Champion", b =>
                {
                    b.HasOne("Trabalho.Models.ChampionAbilities", "Abilities")
                        .WithMany()
                        .HasForeignKey("AbilitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Trabalho.Models.IngameAccount", b =>
                {
                    b.HasOne("Trabalho.Models.UserQuickStat", "QuickStat")
                        .WithMany()
                        .HasForeignKey("QuickStatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Trabalho.Models.Item", b =>
                {
                    b.HasOne("Trabalho.Models.MatchPlayer", null)
                        .WithMany("Build")
                        .HasForeignKey("MatchPlayerId");
                });

            modelBuilder.Entity("Trabalho.Models.Match", b =>
                {
                    b.HasOne("Trabalho.Models.MatchTeam", "TeamBlue")
                        .WithMany()
                        .HasForeignKey("TeamBlueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trabalho.Models.MatchTeam", "TeamRed")
                        .WithMany()
                        .HasForeignKey("TeamRedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trabalho.Models.MatchTeam", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Trabalho.Models.MatchPlayer", b =>
                {
                    b.HasOne("Trabalho.Models.Champion", "Champion")
                        .WithMany()
                        .HasForeignKey("ChampionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trabalho.Models.Match", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trabalho.Models.MatchTeam", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trabalho.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Trabalho.Models.MatchTeam", b =>
                {
                    b.HasOne("Trabalho.Models.User", "User1")
                        .WithMany()
                        .HasForeignKey("User1Id");

                    b.HasOne("Trabalho.Models.User", "User2")
                        .WithMany()
                        .HasForeignKey("User2Id");

                    b.HasOne("Trabalho.Models.User", "User3")
                        .WithMany()
                        .HasForeignKey("User3Id");

                    b.HasOne("Trabalho.Models.User", "User4")
                        .WithMany()
                        .HasForeignKey("User4Id");

                    b.HasOne("Trabalho.Models.User", "User5")
                        .WithMany()
                        .HasForeignKey("User5Id");
                });

            modelBuilder.Entity("Trabalho.Models.User", b =>
                {
                    b.HasOne("Trabalho.Models.IngameAccount", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("Trabalho.Models.UserQuickStat", b =>
                {
                    b.HasOne("Trabalho.Models.Champion", "MainChamp")
                        .WithMany()
                        .HasForeignKey("MainChampId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
