using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SchoolLand.Models;

public partial class DbslandContext : DbContext
{
    public DbslandContext()
    {
    }

    public DbslandContext(DbContextOptions<DbslandContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sgrade> Sgrades { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sgrade>(entity =>
        {
            entity.HasKey(e => e.DegreeId).HasName("PK__SGrade__51D3827FB71E7779");

            entity.ToTable("SGrade");

            entity.Property(e => e.DegreeId)
                .ValueGeneratedNever()
                .HasColumnName("degreeId");
            entity.Property(e => e.Descriptions)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descriptions");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grade");
            entity.Property(e => e.Student).HasColumnName("student");

            entity.HasOne(d => d.StudentNavigation).WithMany(p => p.Sgrades)
                .HasForeignKey(d => d.Student)
                .HasConstraintName("FK__SGrade__student__4E88ABD4");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Students__32C52B999B06D142");

            entity.Property(e => e.StudentId).ValueGeneratedNever();
            entity.Property(e => e.Carnet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.NameStudent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nameStudent");
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pass");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.IdTeacher).HasName("PK__Teacher__582173DE976BE9B9");

            entity.ToTable("Teacher");

            entity.Property(e => e.IdTeacher)
                .ValueGeneratedNever()
                .HasColumnName("idTeacher");
            entity.Property(e => e.Age)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("age");
            entity.Property(e => e.Carnet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carnet");
            entity.Property(e => e.NameTeacher)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nameTeacher");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.YearsSchool)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("yearsSchool");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
