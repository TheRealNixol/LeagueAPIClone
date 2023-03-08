﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trabalho.Data;

namespace Trabalho.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
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

                    b.ToTable("IngameAccounts");
                });

            modelBuilder.Entity("Trabalho.Models.IngameAccountQuickStat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("HighestWinRateChampId")
                        .HasColumnType("int");

                    b.Property<int>("MainChampId")
                        .HasColumnType("int");

                    b.Property<string>("RankFlex")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RankSolo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("HighestWinRateChampId");

                    b.HasIndex("MainChampId");

                    b.ToTable("IngameAccountQuickStats");
                });

            modelBuilder.Entity("Trabalho.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<int>("Gold")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.HasKey("Id");

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

                    b.Property<string>("Winner")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("TeamBlueId");

                    b.HasIndex("TeamRedId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Trabalho.Models.MatchBuild", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Slot1Id")
                        .HasColumnType("int");

                    b.Property<int?>("Slot2Id")
                        .HasColumnType("int");

                    b.Property<int?>("Slot3Id")
                        .HasColumnType("int");

                    b.Property<int?>("Slot4Id")
                        .HasColumnType("int");

                    b.Property<int?>("Slot5Id")
                        .HasColumnType("int");

                    b.Property<int?>("Slot6Id")
                        .HasColumnType("int");

                    b.Property<int?>("TrinketId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Slot1Id");

                    b.HasIndex("Slot2Id");

                    b.HasIndex("Slot3Id");

                    b.HasIndex("Slot4Id");

                    b.HasIndex("Slot5Id");

                    b.HasIndex("Slot6Id");

                    b.HasIndex("TrinketId");

                    b.ToTable("MatchBuilds");
                });

            modelBuilder.Entity("Trabalho.Models.MatchPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<int?>("BuildId")
                        .HasColumnType("int");

                    b.Property<int>("ChampionId")
                        .HasColumnType("int");

                    b.Property<int>("Deaths")
                        .HasColumnType("int");

                    b.Property<float>("Gold")
                        .HasColumnType("float");

                    b.Property<float>("Kda")
                        .HasColumnType("float");

                    b.Property<int>("Kills")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BuildId");

                    b.HasIndex("ChampionId");

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

                    b.Property<float>("TotalGold")
                        .HasColumnType("float");

                    b.Property<int?>("User1Id")
                        .HasColumnType("int");

                    b.Property<int?>("User2Id")
                        .HasColumnType("int");

                    b.Property<int?>("User3Id")
                        .HasColumnType("int");

                    b.Property<int?>("User4Id")
                        .HasColumnType("int");

                    b.Property<int?>("User5Id")
                        .HasColumnType("int");

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
                    b.HasOne("Trabalho.Models.IngameAccountQuickStat", "QuickStat")
                        .WithMany()
                        .HasForeignKey("QuickStatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Trabalho.Models.IngameAccountQuickStat", b =>
                {
                    b.HasOne("Trabalho.Models.Champion", "HighestWinRateChamp")
                        .WithMany()
                        .HasForeignKey("HighestWinRateChampId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trabalho.Models.Champion", "MainChamp")
                        .WithMany()
                        .HasForeignKey("MainChampId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                });

            modelBuilder.Entity("Trabalho.Models.MatchBuild", b =>
                {
                    b.HasOne("Trabalho.Models.Item", "Slot1")
                        .WithMany()
                        .HasForeignKey("Slot1Id");

                    b.HasOne("Trabalho.Models.Item", "Slot2")
                        .WithMany()
                        .HasForeignKey("Slot2Id");

                    b.HasOne("Trabalho.Models.Item", "Slot3")
                        .WithMany()
                        .HasForeignKey("Slot3Id");

                    b.HasOne("Trabalho.Models.Item", "Slot4")
                        .WithMany()
                        .HasForeignKey("Slot4Id");

                    b.HasOne("Trabalho.Models.Item", "Slot5")
                        .WithMany()
                        .HasForeignKey("Slot5Id");

                    b.HasOne("Trabalho.Models.Item", "Slot6")
                        .WithMany()
                        .HasForeignKey("Slot6Id");

                    b.HasOne("Trabalho.Models.Item", "Trinket")
                        .WithMany()
                        .HasForeignKey("TrinketId");
                });

            modelBuilder.Entity("Trabalho.Models.MatchPlayer", b =>
                {
                    b.HasOne("Trabalho.Models.MatchBuild", "Build")
                        .WithMany()
                        .HasForeignKey("BuildId");

                    b.HasOne("Trabalho.Models.Champion", "Champion")
                        .WithMany()
                        .HasForeignKey("ChampionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trabalho.Models.IngameAccount", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Trabalho.Models.MatchTeam", b =>
                {
                    b.HasOne("Trabalho.Models.MatchPlayer", "User1")
                        .WithMany()
                        .HasForeignKey("User1Id");

                    b.HasOne("Trabalho.Models.MatchPlayer", "User2")
                        .WithMany()
                        .HasForeignKey("User2Id");

                    b.HasOne("Trabalho.Models.MatchPlayer", "User3")
                        .WithMany()
                        .HasForeignKey("User3Id");

                    b.HasOne("Trabalho.Models.MatchPlayer", "User4")
                        .WithMany()
                        .HasForeignKey("User4Id");

                    b.HasOne("Trabalho.Models.MatchPlayer", "User5")
                        .WithMany()
                        .HasForeignKey("User5Id");
                });

            modelBuilder.Entity("Trabalho.Models.User", b =>
                {
                    b.HasOne("Trabalho.Models.IngameAccount", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");
                });
#pragma warning restore 612, 618
        }
    }
}
