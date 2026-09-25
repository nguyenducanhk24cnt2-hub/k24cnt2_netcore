using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NdaFirstDatabase.Models;

public partial class NdaLesson10EfContext : DbContext
{
    public NdaLesson10EfContext()
    {
    }

    public NdaLesson10EfContext(DbContextOptions<NdaLesson10EfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NdaMember> NdaMembers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=NdaLesson10EF;uid=sa;pwd=12345@;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NdaMember>(entity =>
        {
            entity.HasKey(e => e.NdaId).HasName("PK__NdaMembe__72810A175B4D8C4D");

            entity.ToTable("NdaMember");

            entity.Property(e => e.NdaId).ValueGeneratedOnAdd();
            entity.Property(e => e.NdaEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NdaFullName).HasMaxLength(50);
            entity.Property(e => e.NdaPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NdaPhone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NdaUserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
