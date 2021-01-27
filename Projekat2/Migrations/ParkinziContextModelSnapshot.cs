﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekat.Models;

namespace Projekat2.Migrations
{
    [DbContext(typeof(ParkinziContext))]
    partial class ParkinziContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Projekat.Models.Mesta", b =>
                {
                    b.Property<string>("Tablica")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Tablica");

                    b.Property<int>("Dani")
                        .HasColumnType("int")
                        .HasColumnName("Dani");

                    b.Property<int>("ID")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Naselje")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Naselje");

                    b.Property<string>("ParkingNaselje")
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("ParkinziID")
                        .HasColumnType("int");

                    b.Property<string>("Povrsina")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Povrsina");

                    b.Property<string>("Tip")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Tip");

                    b.Property<int>("X")
                        .HasColumnType("int")
                        .HasColumnName("X");

                    b.Property<int>("Y")
                        .HasColumnType("int")
                        .HasColumnName("Y");

                    b.HasKey("Tablica");

                    b.HasIndex("ParkingNaselje");

                    b.HasIndex("ParkinziID");

                    b.ToTable("Mesta");
                });

            modelBuilder.Entity("Projekat.Models.Parking", b =>
                {
                    b.Property<string>("Naselje")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Naselje");

                    b.Property<int>("Brojzauzetih")
                        .HasColumnType("int")
                        .HasColumnName("BrojZauzetih");

                    b.Property<int>("ID")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("M")
                        .HasColumnType("int")
                        .HasColumnName("M");

                    b.Property<int>("N")
                        .HasColumnType("int")
                        .HasColumnName("N");

                    b.Property<int?>("ParkinziID")
                        .HasColumnType("int");

                    b.Property<string>("Tip")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Tip");

                    b.HasKey("Naselje");

                    b.HasIndex("ParkinziID");

                    b.ToTable("Parking");
                });

            modelBuilder.Entity("Projekat.Models.Parkinzi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int>("M")
                        .HasColumnType("int")
                        .HasColumnName("M");

                    b.Property<int>("N")
                        .HasColumnType("int")
                        .HasColumnName("N");

                    b.Property<string>("Naziv")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Naziv");

                    b.Property<int>("Num")
                        .HasColumnType("int")
                        .HasColumnName("Num");

                    b.HasKey("ID");

                    b.ToTable("Park");
                });

            modelBuilder.Entity("Projekat.Models.Mesta", b =>
                {
                    b.HasOne("Projekat.Models.Parking", "Parking")
                        .WithMany("Listamesta")
                        .HasForeignKey("ParkingNaselje");

                    b.HasOne("Projekat.Models.Parkinzi", "Parkinzi")
                        .WithMany()
                        .HasForeignKey("ParkinziID");

                    b.Navigation("Parking");

                    b.Navigation("Parkinzi");
                });

            modelBuilder.Entity("Projekat.Models.Parking", b =>
                {
                    b.HasOne("Projekat.Models.Parkinzi", "Parkinzi")
                        .WithMany("Parkings")
                        .HasForeignKey("ParkinziID");

                    b.Navigation("Parkinzi");
                });

            modelBuilder.Entity("Projekat.Models.Parking", b =>
                {
                    b.Navigation("Listamesta");
                });

            modelBuilder.Entity("Projekat.Models.Parkinzi", b =>
                {
                    b.Navigation("Parkings");
                });
#pragma warning restore 612, 618
        }
    }
}
