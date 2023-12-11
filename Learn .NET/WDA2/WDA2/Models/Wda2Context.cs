using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WDA2.Models;

public partial class Wda2Context : DbContext
{
    public Wda2Context()
    {
    }

    public Wda2Context(DbContextOptions<Wda2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:MyConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC07BDD10FF3");

            entity.ToTable("Employee");

            entity.Property(e => e.Id)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Position).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK_Pos_Emp");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Position__3214EC07B01A14A4");

            entity.ToTable("Position");

            entity.Property(e => e.Position1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Position");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
