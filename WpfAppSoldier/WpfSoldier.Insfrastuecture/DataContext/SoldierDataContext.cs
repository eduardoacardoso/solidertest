using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WpfSoldier.Domain.Entities;

namespace WpfSoldier.Infrastructure.DataContext
{

    public partial class SoldierDataContext : DbContext
    {
        public SoldierDataContext()
        {
        }

        public SoldierDataContext(DbContextOptions<SoldierDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Position> Positions { get; set; }

        public virtual DbSet<Sensor> Sensors { get; set; }

        public virtual DbSet<Soldier> Soldiers { get; set; }

        public virtual DbSet<Training> Training { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=DESKTOP-IGQP4QF\\SQLEXPRESS;Initial Catalog=SoldierData;user id=sa;password=123456q!; Integrated Security=True;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("Position");

                entity.Property(e => e.PositionId)
                    .ValueGeneratedNever()
                    .HasColumnName("PositionID");
                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");
                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");
                entity.Property(e => e.SoldierId).HasColumnName("SoldierID");

                entity.HasOne(d => d.Soldier).WithMany(p => p.Positions)
                    .HasForeignKey(d => d.SoldierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Position_Soldier");
            });

            modelBuilder.Entity<Sensor>(entity =>
            {
                entity.ToTable("Sensor");

                entity.Property(e => e.SensorId)
                    .ValueGeneratedNever()
                    .HasColumnName("SensorID");
                entity.Property(e => e.SensorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SensorType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SoldierId).HasColumnName("SoldierID");

                entity.HasOne(d => d.Soldier).WithMany(p => p.Sensors)
                    .HasForeignKey(d => d.SoldierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sensor_Soldier");
            });

            modelBuilder.Entity<Soldier>(entity =>
            {
                entity.ToTable("Soldier");

                entity.Property(e => e.SoldierId)
                    .ValueGeneratedNever()
                    .HasColumnName("SoldierID");
                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Rank)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Training>(entity =>
            {
                entity.Property(e => e.TrainingId)
                    .ValueGeneratedNever()
                    .HasColumnName("TrainingID");
                entity.Property(e => e.SoldierId).HasColumnName("SoldierID");
                entity.Property(e => e.TraningIformation).IsUnicode(false);

                entity.HasOne(d => d.Soldier).WithMany(p => p.Training)
                    .HasForeignKey(d => d.SoldierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Training_Soldier");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
