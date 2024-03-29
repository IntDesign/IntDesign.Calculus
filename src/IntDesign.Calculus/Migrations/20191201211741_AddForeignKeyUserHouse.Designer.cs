﻿// <auto-generated />
using System;
using Calculus.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Calculus.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191201211741_AddForeignKeyUserHouse")]
    partial class AddForeignKeyUserHouse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Calculus.Core.Models.House", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HouseAddress");

                    b.Property<string>("OwnerEmail");

                    b.Property<string>("OwnerName");

                    b.Property<string>("OwnerPhone");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("Calculus.Core.Models.Material", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MaterialName");

                    b.Property<Guid>("RoomJobId");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("RoomJobId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialExpenditure", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("MaterialInformationId");

                    b.Property<double?>("TotalPackets");

                    b.Property<double?>("TotalPrice");

                    b.Property<double?>("TotalQuantity");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("MaterialInformationId")
                        .IsUnique();

                    b.ToTable("MaterialExpenditures");
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double?>("AppliedLayers");

                    b.Property<double?>("ConsumptionX");

                    b.Property<double?>("ConsumptionZ");

                    b.Property<Guid>("MaterialId");

                    b.Property<double?>("PricePerUnit");

                    b.Property<double?>("ProductQuantity");

                    b.Property<Guid?>("ProviderId");

                    b.Property<double?>("UnitCover");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("MaterialId")
                        .IsUnique();

                    b.HasIndex("ProviderId");

                    b.ToTable("MaterialInformation");
                });

            modelBuilder.Entity("Calculus.Core.Models.Provider", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProviderAddress");

                    b.Property<string>("ProviderEmail");

                    b.Property<string>("ProviderName");

                    b.Property<string>("ProviderPhone");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("Calculus.Core.Models.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double?>("Afm");

                    b.Property<double>("Asp");

                    b.Property<double>("Atv");

                    b.Property<double?>("CustomHeightOne");

                    b.Property<double?>("CustomHeightTwo");

                    b.Property<double?>("CustomLenght");

                    b.Property<double?>("CustomWidth");

                    b.Property<double>("EmptyAsp");

                    b.Property<double>("Height");

                    b.Property<Guid>("HouseId");

                    b.Property<double>("Lenght");

                    b.Property<double>("Pc");

                    b.Property<double?>("SpecialAfm");

                    b.Property<double?>("SpecialTilesParquetCoefficient");

                    b.Property<double?>("TilesParquetCoefficient");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<double?>("WallRealCoefficient");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.HasIndex("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Calculus.Core.Models.RoomJob", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("FinishDate");

                    b.Property<Guid>("RoomId");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomJobs");
                });

            modelBuilder.Entity("Calculus.Core.Models.RoomWallObject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Area");

                    b.Property<double>("Lenght");

                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(1);

                    b.Property<Guid>("RoomId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomWallObjects");
                });

            modelBuilder.Entity("Calculus.Core.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<bool>("IsWorker")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Calculus.Core.Models.House", b =>
                {
                    b.HasOne("Calculus.Core.Models.User", "User")
                        .WithMany("Houses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Calculus.Core.Models.Material", b =>
                {
                    b.HasOne("Calculus.Core.Models.RoomJob", "RoomJob")
                        .WithMany("Materials")
                        .HasForeignKey("RoomJobId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialExpenditure", b =>
                {
                    b.HasOne("Calculus.Core.Models.MaterialInformation", "MaterialInformation")
                        .WithOne("MaterialExpenditure")
                        .HasForeignKey("Calculus.Core.Models.MaterialExpenditure", "MaterialInformationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialInformation", b =>
                {
                    b.HasOne("Calculus.Core.Models.Material", "Material")
                        .WithOne("MaterialInformation")
                        .HasForeignKey("Calculus.Core.Models.MaterialInformation", "MaterialId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Calculus.Core.Models.Provider", "Provider")
                        .WithMany("MaterialInformations")
                        .HasForeignKey("ProviderId");
                });

            modelBuilder.Entity("Calculus.Core.Models.Room", b =>
                {
                    b.HasOne("Calculus.Core.Models.House", "House")
                        .WithMany("HouseRooms")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Calculus.Core.Models.RoomJob", b =>
                {
                    b.HasOne("Calculus.Core.Models.Room", "Room")
                        .WithMany("RoomJobs")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Calculus.Core.Models.RoomWallObject", b =>
                {
                    b.HasOne("Calculus.Core.Models.Room", "Room")
                        .WithMany("RoomObjects")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
