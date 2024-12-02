using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EF_Lab1.Models;

public partial class CompanyContext : DbContext
{
    public CompanyContext()
    {
    }

    public CompanyContext(DbContextOptions<CompanyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Dependent> Dependents { get; set; }

    public virtual DbSet<DeptLocation> DeptLocations { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<WorksOn> WorksOns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-6H9B8GJ\\SQLEXPRESS;Database=Company;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Dnumber).HasName("PK__DEPARTME__F5A98606B0AE41D2");

            entity.ToTable("DEPARTMENT");

            entity.Property(e => e.Dnumber)
                .ValueGeneratedNever()
                .HasColumnName("DNUMBER");
            entity.Property(e => e.Dname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DNAME");
            entity.Property(e => e.Mgrssn).HasColumnName("MGRSSN");
            entity.Property(e => e.Mgrstartdate).HasColumnName("MGRSTARTDATE");

            entity.HasOne(d => d.MgrssnNavigation).WithMany(p => p.Departments)
                .HasForeignKey(d => d.Mgrssn)
                .HasConstraintName("FK__DEPARTMEN__MGRSS__3D5E1FD2");
        });

        modelBuilder.Entity<Dependent>(entity =>
        {
            entity.HasKey(e => new { e.Essn, e.DependentName }).HasName("PK__DEPENDEN__82CB958223C563AC");

            entity.ToTable("DEPENDENT");

            entity.Property(e => e.Essn).HasColumnName("ESSN");
            entity.Property(e => e.DependentName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEPENDENT_NAME");
            entity.Property(e => e.Bdate).HasColumnName("BDATE");
            entity.Property(e => e.Relationship)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELATIONSHIP");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEX");

            entity.HasOne(d => d.EssnNavigation).WithMany(p => p.Dependents)
                .HasForeignKey(d => d.Essn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DEPENDENT__ESSN__4AB81AF0");
        });

        modelBuilder.Entity<DeptLocation>(entity =>
        {
            entity.HasKey(e => new { e.Dnumber, e.Dlocation }).HasName("PK__DEPT_LOC__2F9748E07A1EBDDD");

            entity.ToTable("DEPT_LOCATIONS");

            entity.Property(e => e.Dnumber).HasColumnName("DNUMBER");
            entity.Property(e => e.Dlocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLOCATION");

            entity.HasOne(d => d.DnumberNavigation).WithMany(p => p.DeptLocations)
                .HasForeignKey(d => d.Dnumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DEPT_LOCA__DNUMB__412EB0B6");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Ssn).HasName("PK__EMPLOYEE__CA1E8E3D203680DE");

            entity.ToTable("EMPLOYEE");

            entity.Property(e => e.Ssn)
                .ValueGeneratedNever()
                .HasColumnName("SSN");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Bdate).HasColumnName("BDATE");
            entity.Property(e => e.Dno).HasColumnName("DNO");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FNAME");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LNAME");
            entity.Property(e => e.Minit)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MINIT");
            entity.Property(e => e.Salary)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SALARY");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEX");
            entity.Property(e => e.Superssn).HasColumnName("SUPERSSN");

            entity.HasOne(d => d.DnoNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.Dno)
                .HasConstraintName("FK_EMPLOYEE_DEPARTMENT");

            entity.HasOne(d => d.SuperssnNavigation).WithMany(p => p.InverseSuperssnNavigation)
                .HasForeignKey(d => d.Superssn)
                .HasConstraintName("FK__EMPLOYEE__SUPERS__3A81B327");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Pnumber).HasName("PK__PROJECT__EC4259AF9DB470AD");

            entity.ToTable("PROJECT");

            entity.Property(e => e.Pnumber)
                .ValueGeneratedNever()
                .HasColumnName("PNUMBER");
            entity.Property(e => e.Dnum).HasColumnName("DNUM");
            entity.Property(e => e.Plocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLOCATION");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PNAME");

            entity.HasOne(d => d.DnumNavigation).WithMany(p => p.Projects)
                .HasForeignKey(d => d.Dnum)
                .HasConstraintName("FK__PROJECT__DNUM__440B1D61");
        });

        modelBuilder.Entity<WorksOn>(entity =>
        {
            entity.HasKey(e => new { e.Essn, e.Pno }).HasName("PK__WORKS_ON__CF59EC3020C8481D");

            entity.ToTable("WORKS_ON");

            entity.Property(e => e.Essn).HasColumnName("ESSN");
            entity.Property(e => e.Pno).HasColumnName("PNO");
            entity.Property(e => e.Hours)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("HOURS");

            entity.HasOne(d => d.EssnNavigation).WithMany(p => p.WorksOns)
                .HasForeignKey(d => d.Essn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WORKS_ON__ESSN__46E78A0C");

            entity.HasOne(d => d.PnoNavigation).WithMany(p => p.WorksOns)
                .HasForeignKey(d => d.Pno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WORKS_ON__PNO__47DBAE45");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
