﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkingSystem_API.Data;

#nullable disable

namespace ParkingSystem_API.Migrations
{
    [DbContext(typeof(ParkingSystemDbContext))]
    partial class ParkingSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ParkingSystem_API.Model.ParkingDetails", b =>
                {
                    b.Property<int>("FloorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FloorId"), 1L, 1);

                    b.Property<bool>("Slot1")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot10")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot11")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot12")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot13")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot14")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot15")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot16")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot17")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot18")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot19")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot2")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot20")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot3")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot4")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot5")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot6")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot7")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot8")
                        .HasColumnType("bit");

                    b.Property<bool>("Slot9")
                        .HasColumnType("bit");

                    b.HasKey("FloorId");

                    b.ToTable("parkingDetails");
                });

            modelBuilder.Entity("ParkingSystem_API.Model.ParkingSummary", b =>
                {
                    b.Property<int>("ZoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZoneId"), 1L, 1);

                    b.Property<int>("FilledSlots")
                        .HasColumnType("int");

                    b.Property<int>("TotalSlots")
                        .HasColumnType("int");

                    b.Property<string>("ZoneTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZoneId");

                    b.ToTable("parkingSummaries");
                });

            modelBuilder.Entity("ParkingSystem_API.Model.VehicleDbModel", b =>
                {
                    b.Property<Guid>("Vehicle_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<int>("FloorId")
                        .HasColumnType("int");

                    b.Property<string>("Owner_Name")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("ParkingPin")
                        .HasColumnType("int");

                    b.Property<DateTime>("ParkingTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("SlotId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UnparkingTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Vehicle_Number")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Vehicle_Id");

                    b.ToTable("vehicleDbModels");
                });
#pragma warning restore 612, 618
        }
    }
}
