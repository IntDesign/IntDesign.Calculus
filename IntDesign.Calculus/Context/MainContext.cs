using System;
using Calculus.Core.Models.Enums;
using Calculus.Core.Models.MainModels;
using Calculus.Core.Models.SecondaryModels;
using Calculus.Core.Models.Tools;
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
                .HasOne(r => r.House)
                .WithMany(h => h.HouseRooms)
                .HasForeignKey(r => r.HouseId);

            modelBuilder.Entity<RoomWallObject>()
                .HasOne(rw => rw.Room)
                .WithMany(r => r.RoomObjects)
                .HasForeignKey(rw => rw.RoomId);
            modelBuilder.Entity<RoomJob>().HasKey(rj => rj.Id);

            modelBuilder.Entity<RoomJob>()
                .HasOne(rj => rj.Room)
                .WithMany(r => r.RoomJobs)
                .HasForeignKey(rj => rj.RoomId);

            modelBuilder.Entity<Provider>()
                .HasOne(p => p.Material)
                .WithOne(m => m.Provider)
                .HasForeignKey<Provider>(p => p.MaterialId);

            modelBuilder.Entity<MaterialExpenditure>()
                .HasOne(me => me.Material)
                .WithOne(m => m.MaterialExpenditure)
                .HasForeignKey<MaterialExpenditure>(me => me.MaterialId);

            modelBuilder.Entity<MaterialInformation>()
                .HasOne(mi => mi.Material)
                .WithOne(m => m.MaterialInformation)
                .HasForeignKey<MaterialInformation>(mi => mi.MaterialId);
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