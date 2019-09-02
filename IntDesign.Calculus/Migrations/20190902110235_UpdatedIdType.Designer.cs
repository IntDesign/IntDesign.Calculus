﻿// <auto-generated />
using System;
using Calculus.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Calculus.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20190902110235_UpdatedIdType")]
    partial class UpdatedIdType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Calculus.Core.Models.JobModels.House", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HouseAddress");

                    b.Property<string>("OwnerEmail");

                    b.Property<string>("OwnerName");

                    b.Property<string>("OwnerPhone");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("Calculus.Core.Models.JobModels.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Afm");

                    b.Property<float>("Asp");

                    b.Property<float>("EmptyAsp");

                    b.Property<float>("Height");

                    b.Property<Guid>("HouseId");

                    b.Property<float>("Lenght");

                    b.Property<float>("SpecialAfm");

                    b.Property<float>("Widtd");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.HasIndex("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Calculus.Core.Models.JobModels.RoomJob", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("FinishDate");

                    b.Property<Guid>("RoomId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("RoomId")
                        .IsUnique();

                    b.ToTable("RoomJobs");
                });

            modelBuilder.Entity("Calculus.Core.Models.JobModels.RoomWallObject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Area");

                    b.Property<float>("Height");

                    b.Property<float>("Lenght");

                    b.Property<Guid>("RoomId");

                    b.Property<int>("Type");

                    b.Property<float>("Width");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomWallObjects");
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialModels.Material", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MaterialName");

                    b.Property<int>("MaterialType");

                    b.Property<float>("PricePerPacket");

                    b.Property<Guid?>("RoomJobId");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("RoomJobId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialModels.MaterialExpenditure", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("MaterialId");

                    b.Property<float>("TotalKilograms");

                    b.Property<float>("TotalPackets");

                    b.Property<float>("TotalPrice");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("MaterialId")
                        .IsUnique();

                    b.ToTable("MaterialExpenditures");
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialModels.MaterialInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("AppliedLayers");

                    b.Property<float>("ComsumptionZ");

                    b.Property<float>("ConsumptionX");

                    b.Property<Guid>("MaterialId");

                    b.Property<float>("UnitCover");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("MaterialId")
                        .IsUnique();

                    b.ToTable("MaterialInformations");
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialModels.Provider", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("MaterialId");

                    b.Property<string>("ProviderAddress");

                    b.Property<string>("ProviderEmail");

                    b.Property<string>("ProviderName");

                    b.Property<string>("ProviderPhone");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("MaterialId")
                        .IsUnique();

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("Calculus.Core.Models.JobModels.Room", b =>
                {
                    b.HasOne("Calculus.Core.Models.JobModels.House", "House")
                        .WithMany("HouseRooms")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Calculus.Core.Models.JobModels.RoomJob", b =>
                {
                    b.HasOne("Calculus.Core.Models.JobModels.Room", "Room")
                        .WithOne("RoomJob")
                        .HasForeignKey("Calculus.Core.Models.JobModels.RoomJob", "RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Calculus.Core.Models.JobModels.RoomWallObject", b =>
                {
                    b.HasOne("Calculus.Core.Models.JobModels.Room", "Room")
                        .WithMany("RoomObjects")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialModels.Material", b =>
                {
                    b.HasOne("Calculus.Core.Models.JobModels.RoomJob")
                        .WithMany("Materials")
                        .HasForeignKey("RoomJobId");
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialModels.MaterialExpenditure", b =>
                {
                    b.HasOne("Calculus.Core.Models.MaterialModels.Material", "Material")
                        .WithOne("MaterialExpenditure")
                        .HasForeignKey("Calculus.Core.Models.MaterialModels.MaterialExpenditure", "MaterialId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialModels.MaterialInformation", b =>
                {
                    b.HasOne("Calculus.Core.Models.MaterialModels.Material", "Material")
                        .WithOne("MaterialInformation")
                        .HasForeignKey("Calculus.Core.Models.MaterialModels.MaterialInformation", "MaterialId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialModels.Provider", b =>
                {
                    b.HasOne("Calculus.Core.Models.MaterialModels.Material", "Material")
                        .WithOne("Provider")
                        .HasForeignKey("Calculus.Core.Models.MaterialModels.Provider", "MaterialId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
