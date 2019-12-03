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
    [Migration("20190829142359_BasicModelsAddedUpdatedNaming")]
    partial class BasicModelsAddedUpdatedNaming
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Calculus.Core.Models.HouseModels.House", b =>
                {
                    b.Property<Guid>("HouseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HouseAddress");

                    b.Property<string>("OwnerEmail");

                    b.Property<string>("OwnerName");

                    b.Property<string>("OwnerPhone");

                    b.HasKey("HouseId");

                    b.HasIndex("HouseId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("Calculus.Core.Models.HouseModels.Room", b =>
                {
                    b.Property<Guid>("RoomId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Afm");

                    b.Property<float>("Asp");

                    b.Property<float>("EmptyAsp");

                    b.Property<float>("Height");

                    b.Property<Guid>("HouseId");

                    b.Property<float>("Lenght");

                    b.Property<float>("SpecialAfm");

                    b.Property<float>("Widtd");

                    b.HasKey("RoomId");

                    b.HasIndex("HouseId");

                    b.HasIndex("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Calculus.Core.Models.HouseModels.RoomJob", b =>
                {
                    b.Property<Guid>("RoomJobId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("FinishDate");

                    b.Property<Guid?>("MaterialExpenditureId");

                    b.Property<Guid>("RoomId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("RoomJobId");

                    b.HasIndex("MaterialExpenditureId");

                    b.HasIndex("RoomId")
                        .IsUnique();

                    b.HasIndex("RoomJobId");

                    b.ToTable("RoomJobs");
                });

            modelBuilder.Entity("Calculus.Core.Models.HouseModels.RoomWallObject", b =>
                {
                    b.Property<Guid>("RoomWallObjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Area");

                    b.Property<float>("Height");

                    b.Property<float>("Lenght");

                    b.Property<Guid>("RoomId");

                    b.Property<int>("Type");

                    b.Property<float>("Width");

                    b.HasKey("RoomWallObjectId");

                    b.HasIndex("RoomId");

                    b.HasIndex("RoomWallObjectId");

                    b.ToTable("RoomWallObjects");
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialModels.Material", b =>
                {
                    b.Property<Guid>("MaterialId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MaterialName");

                    b.Property<int>("MaterialType");

                    b.Property<float>("PricePerPacket");

                    b.Property<Guid?>("RoomJobId");

                    b.HasKey("MaterialId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("RoomJobId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialModels.MaterialExpenditure", b =>
                {
                    b.Property<Guid>("MaterialExpenditureId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("MaterialId");

                    b.Property<float>("TotalKilograms");

                    b.Property<float>("TotalPackets");

                    b.Property<float>("TotalPrice");

                    b.HasKey("MaterialExpenditureId");

                    b.HasIndex("MaterialExpenditureId");

                    b.HasIndex("MaterialId")
                        .IsUnique();

                    b.ToTable("MaterialExpenditures");
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialModels.MaterialInformation", b =>
                {
                    b.Property<Guid>("MaterialInformationId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("AppliedLayers");

                    b.Property<float>("ComsumptionZ");

                    b.Property<float>("ConsumptionX");

                    b.Property<Guid>("MaterialId");

                    b.Property<float>("UnitCover");

                    b.HasKey("MaterialInformationId");

                    b.HasIndex("MaterialId")
                        .IsUnique();

                    b.HasIndex("MaterialInformationId");

                    b.ToTable("MaterialInformations");
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialModels.Provider", b =>
                {
                    b.Property<Guid>("ProviderId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("MaterialId");

                    b.Property<string>("ProviderAddress");

                    b.Property<string>("ProviderEmail");

                    b.Property<string>("ProviderName");

                    b.Property<string>("ProviderPhone");

                    b.HasKey("ProviderId");

                    b.HasIndex("MaterialId")
                        .IsUnique();

                    b.HasIndex("ProviderId");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("Calculus.Core.Models.HouseModels.Room", b =>
                {
                    b.HasOne("Calculus.Core.Models.HouseModels.House", "House")
                        .WithMany("HouseRooms")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Calculus.Core.Models.HouseModels.RoomJob", b =>
                {
                    b.HasOne("Calculus.Core.Models.MaterialModels.MaterialExpenditure", "MaterialExpenditure")
                        .WithMany()
                        .HasForeignKey("MaterialExpenditureId");

                    b.HasOne("Calculus.Core.Models.HouseModels.Room", "Room")
                        .WithOne("RoomJob")
                        .HasForeignKey("Calculus.Core.Models.HouseModels.RoomJob", "RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Calculus.Core.Models.HouseModels.RoomWallObject", b =>
                {
                    b.HasOne("Calculus.Core.Models.HouseModels.Room", "Room")
                        .WithMany("RoomObjects")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Calculus.Core.Models.MaterialModels.Material", b =>
                {
                    b.HasOne("Calculus.Core.Models.HouseModels.RoomJob")
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