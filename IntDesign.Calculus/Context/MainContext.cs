using System;
using Calculus.Core.Enums;
using Calculus.Core.Models;
using Calculus.Core.Tools;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Calculus.Context
{
    public class MainContext : DbContext
    {
        private readonly AppSettings m_appSettings;

        public MainContext(DbContextOptions options, IOptions<AppSettings> appSettings) : base(options) =>
            m_appSettings = appSettings.Value;

        public DbSet<House> Houses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomJob> RoomJobs { get; set; }
        public DbSet<RoomWallObject> RoomWallObjects { get; set; }

        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialExpenditure> MaterialExpenditures { get; set; }
        public DbSet<MaterialInformation> MaterialInformation { get; set; }
        public DbSet<Provider> Providers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseMySql(m_appSettings.ConnectionString);
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.EnableDetailedErrors();
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SetPrimaryKeys(modelBuilder);
            SetForeignKeys(modelBuilder);
            SetAllIndex(modelBuilder);
            SetEnumConversion(modelBuilder);
            SetDefaultValues(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private static void SetPrimaryKeys(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<House>().HasKey(h => h.Id);
            modelBuilder.Entity<Room>().HasKey(r => r.Id);
            modelBuilder.Entity<RoomJob>().HasKey(rj => rj.Id);
            modelBuilder.Entity<RoomWallObject>().HasKey(rw => rw.Id);

            modelBuilder.Entity<Material>().HasKey(m => m.Id);
            modelBuilder.Entity<MaterialExpenditure>().HasKey(me => me.Id);
            modelBuilder.Entity<MaterialInformation>().HasKey(mi => mi.Id);
            modelBuilder.Entity<Provider>().HasIndex(p => p.Id);
            
        }

        private static void SetForeignKeys(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .HasOne(t => t.House)
                .WithMany(t => t.HouseRooms)
                .HasForeignKey(t => t.HouseId);

            modelBuilder.Entity<RoomWallObject>()
                .HasOne(rw => rw.Room)
                .WithMany(t => t.RoomObjects)
                .HasForeignKey(t => t.RoomId);

            modelBuilder.Entity<RoomJob>()
                .HasOne(t => t.Room)
                .WithMany(t => t.RoomJobs)
                .HasForeignKey(t => t.RoomId);
            
            modelBuilder.Entity<Material>()
                .HasOne(t => t.RoomJob)
                .WithMany(t => t.Materials)
                .HasForeignKey(t => t.RoomJobId);
            
            modelBuilder.Entity<MaterialInformation>()
                .HasOne(t => t.Material)
                .WithOne(t => t.MaterialInformation)
                .HasForeignKey<MaterialInformation>(t => t.MaterialId);
            
            modelBuilder.Entity<MaterialExpenditure>()
                .HasOne(t => t.MaterialInformation)
                .WithOne(t => t.MaterialExpenditure)
                .HasForeignKey<MaterialExpenditure>(t => t.MaterialInformationId);
            
            modelBuilder.Entity<MaterialInformation>()
                .HasOne(t => t.Material)
                .WithOne(t => t.MaterialInformation)
                .HasForeignKey<MaterialInformation>(t => t.MaterialId);
            
            modelBuilder.Entity<MaterialInformation>()
                .HasOne(t => t.Provider)
                .WithMany(t => t.MaterialInformations)
                .HasForeignKey(t => t.ProviderId);
        }

        private static void SetAllIndex(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<House>().HasIndex(h => h.Id);
            modelBuilder.Entity<Room>().HasIndex(r => r.Id);
            modelBuilder.Entity<RoomJob>().HasIndex(rj => rj.Id);
            modelBuilder.Entity<RoomWallObject>().HasIndex(rw => rw.Id);

            modelBuilder.Entity<Material>().HasIndex(m => m.Id);
            modelBuilder.Entity<MaterialInformation>().HasIndex(mi => mi.Id);
            modelBuilder.Entity<MaterialExpenditure>().HasIndex(me => me.Id);
            modelBuilder.Entity<Provider>().HasIndex(p => p.Id);
        }

        private static void SetEnumConversion(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().Property(t => t.Type).HasConversion(
                e => e.ToString(),
                p => (RoomType) Enum.Parse(typeof(RoomType), p)
            ).HasColumnType("varchar(40)");

            modelBuilder.Entity<RoomWallObject>().Property(t => t.Type).HasConversion(
                e => e.ToString(),
                p => (RoomObjectType) Enum.Parse(typeof(RoomObjectType), p)
            ).HasColumnType("varchar(40)");
            
            modelBuilder.Entity<RoomJob>().Property(t => t.Type).HasConversion(
                e => e.ToString(),
                p => (JobRequestType) Enum.Parse(typeof(JobRequestType), p)
            ).HasColumnType("varchar(40)");
        }

        private static void SetDefaultValues(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomWallObject>()
                .Property(t => t.Number)
                .HasDefaultValue(1);
        }
    }
}