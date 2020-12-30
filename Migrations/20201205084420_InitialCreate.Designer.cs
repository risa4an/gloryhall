﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gloryhall.Data.Models;

namespace gloryhall.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20201205084420_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("gloryhall.Data.Models.Match", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("scoresTeam1")
                        .HasColumnType("smallint");

                    b.Property<short>("scoresTeam2")
                        .HasColumnType("smallint");

                    b.Property<string>("team1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("team2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tournament")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("gloryhall.Data.Models.Message", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Threadid")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("idThread")
                        .HasColumnType("int");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Threadid");

                    b.ToTable("messages");
                });

            modelBuilder.Entity("gloryhall.Data.Models.Thread", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("matchid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("matchid");

                    b.ToTable("Thread");
                });

            modelBuilder.Entity("gloryhall.Data.Models.Message", b =>
                {
                    b.HasOne("gloryhall.Data.Models.Thread", "Thread")
                        .WithMany("messages")
                        .HasForeignKey("Threadid");

                    b.Navigation("Thread");
                });

            modelBuilder.Entity("gloryhall.Data.Models.Thread", b =>
                {
                    b.HasOne("gloryhall.Data.Models.Match", "match")
                        .WithMany()
                        .HasForeignKey("matchid");

                    b.Navigation("match");
                });

            modelBuilder.Entity("gloryhall.Data.Models.Thread", b =>
                {
                    b.Navigation("messages");
                });
#pragma warning restore 612, 618
        }
    }
}