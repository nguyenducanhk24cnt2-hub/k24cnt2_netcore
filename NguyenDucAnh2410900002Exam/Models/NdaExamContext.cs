using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NguyenDucAnh2410900002Exam.Models;

public partial class NdaExamContext : DbContext
{
    public NdaExamContext()
    {
    }

    public NdaExamContext(DbContextOptions<NdaExamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NdaEmployee> NdaEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=NdaExam;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NdaEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NdaEmplo__3214EC07D74F0AA3");

            entity.ToTable("NdaEmployee");

            entity.HasIndex(e => e.NdaEmail, "UQ__NdaEmplo__A4F51CBC43D8B47C").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NdaActive).HasDefaultValue(true);
            entity.Property(e => e.NdaEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NdaGender).HasMaxLength(10);
            entity.Property(e => e.NdaName).HasMaxLength(100);
            entity.Property(e => e.NdaPhone)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
