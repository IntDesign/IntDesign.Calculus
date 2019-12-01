using System;
using Calculus.Core.Enums;
using Calculus.Core.Models;
using Calculus.Core.Tools;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Calculus.Context
{
    public class DataContext : DbContext
    {
        private readonly AppSettings m_appSettings;

        public DataContext(DbContextOptions options, IOptions<AppSettings> appSettings) : base(options) =>
            m_appSettings = appSettings.Value;

        public DbSet<House> Houses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomJob> RoomJobs { get; set; }
        public DbSet<RoomWallObject> RoomWallObjects { get; set; }

        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialExpenditure> MaterialExpenditures { get; set; }
        public DbSet<MaterialInformation> MaterialInformation { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<User> Users { get; set; }

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
            modelBuilder.Entity<User>().HasKey(t => t.Id);
            modelBuilder.Entity<House>().HasKey(t => t.Id);
            modelBuilder.Entity<Room>().HasKey(t => t.Id);
            modelBuilder.Entity<RoomJob>().HasKey(t => t.Id);
            modelBuilder.Entity<RoomWallObject>().HasKey(t => t.Id);

            modelBuilder.Entity<Material>().HasKey(t => t.Id);
            modelBuilder.Entity<MaterialExpenditure>().HasKey(t => t.Id);
            modelBuilder.Entity<MaterialInformation>().HasKey(t => t.Id);
            modelBuilder.Entity<Provider>().HasIndex(t => t.Id);
        }

        private static void SetForeignKeys(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<House>()
                .HasOne(t => t.User)
                .WithMany(t => t.Houses)
                .HasForeignKey(t => t.UserId);

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
            modelBuilder.Entity<User>().HasIndex(t => t.Id);
            modelBuilder.Entity<House>().HasIndex(t => t.Id);
            modelBuilder.Entity<Room>().HasIndex(t => t.Id);
            modelBuilder.Entity<RoomJob>().HasIndex(t => t.Id);
            modelBuilder.Entity<RoomWallObject>().HasIndex(t => t.Id);

            modelBuilder.Entity<Material>().HasIndex(t => t.Id);
            modelBuilder.Entity<MaterialInformation>().HasIndex(t => t.Id);
            modelBuilder.Entity<MaterialExpenditure>().HasIndex(t => t.Id);
            modelBuilder.Entity<Provider>().HasIndex(t => t.Id);
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
            modelBuilder.Entity<User>()
                .Property(t => t.IsWorker)
                .HasDefaultValue(true);

            modelBuilder.Entity<RoomWallObject>()
                .Property(t => t.Number)
                .HasDefaultValue(1);
        }
    }
}