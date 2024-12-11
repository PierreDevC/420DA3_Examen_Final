using _420DA3_Examen_Final.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.DataAccess;
internal class AppDbContext : DbContext
{
    public DbSet<Etudiant> Etudiants { get; set; }
    public DbSet<Cours> Courses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        string connString = ConfigurationManager.ConnectionStrings["ProjectDatabase_Final"].ConnectionString;
        optionsBuilder
            .UseSqlServer(connString)
            .UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        _ = modelBuilder.Entity<Etudiant>()
            .ToTable(nameof(this.Etudiants))
            .HasKey(e => e.Id);

        _ = modelBuilder.Entity<Cours>()
            .ToTable(nameof(this.Courses))
            .HasKey(c => c.Id);


        _ = modelBuilder.Entity<Etudiant>()
            .Property(e => e.Id)
            .HasColumnType("int")
            .HasColumnOrder(0)
            .HasColumnName(nameof(Etudiant.Id))
            .IsRequired(true)
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Etudiant>()
            .Property(e => e.FirstName)
            .HasColumnType($"nvarchar({Etudiant.FirstNameMaxLength})")
            .HasMaxLength(Etudiant.FirstNameMaxLength)
            .HasColumnOrder(1)
            .HasColumnName(nameof(Etudiant.FirstName))
            .IsRequired(true);

        _ = modelBuilder.Entity<Etudiant>()
            .Property(e => e.LastName)
            .HasColumnType($"nvarchar({Etudiant.LastNameMaxLength})")
            .HasMaxLength(Etudiant.LastNameMaxLength)
            .HasColumnOrder(2)
            .HasColumnName(nameof(Etudiant.LastName))
            .IsRequired(true);

        _ = modelBuilder.Entity<Etudiant>()
            .Property(e => e.RowVersion)
            .HasColumnOrder(3)
            .HasColumnName(nameof(Etudiant.RowVersion))
            .IsRequired(true)
            .IsRowVersion();




        _ = modelBuilder.Entity<Cours>()
            .Property(c => c.Id)
            .HasColumnType("int")
            .HasColumnOrder(0)
            .HasColumnName(nameof(Cours.Id))
            .IsRequired(true)
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Cours>()
            .Property(c => c.CourseCode)
            .HasColumnType($"nvarchar({Cours.CourseCodeMaxLength})")
            .HasMaxLength(Cours.CourseCodeMaxLength)
            .HasColumnOrder(1)
            .HasColumnName(nameof(Cours.CourseCode))
            .IsRequired(true);

        _ = modelBuilder.Entity<Cours>()
            .Property(c => c.CourseTitle)
            .HasColumnType($"nvarchar({Cours.CourseTitleMaxLength})")
            .HasMaxLength(Cours.CourseTitleMaxLength)
            .HasColumnOrder(2)
            .HasColumnName(nameof(Cours.CourseTitle))
            .IsRequired(true);

        _ = modelBuilder.Entity<Cours>()
            .Property(c => c.RowVersion)
            .HasColumnOrder(3)
            .HasColumnName(nameof(Cours.RowVersion))
            .IsRequired(true)
            .IsRowVersion();


        _ = modelBuilder.Entity<Cours>()
            .HasData(
                new Cours { Id = 1, CourseCode = "420DA3AS ", CourseTitle = "Applications Multi-Tiers" },
                new Cours { Id = 2, CourseCode = "420DW3AS", CourseTitle = "Web Serveur I" },
                new Cours { Id = 3, CourseCode = "420PA3AS ", CourseTitle = "Orienté-Objet Avancé" }
            );

        _ = modelBuilder.Entity<Etudiant>()
            .HasData(
                new Etudiant { Id = 1, FirstName = "John", LastName = "Doe" },
                new Etudiant { Id = 2, FirstName = "Jane", LastName = "Doe" }
            );


        _ = modelBuilder.Entity<Etudiant>()
            .HasMany(e => e.Courses)
            .WithMany(c => c.EtudiantInscrits)
            .UsingEntity(
                "CoursEtudiant",
                right =>
                {
                    return right.HasOne(typeof(Cours)).WithMany().HasForeignKey("CoursId").HasPrincipalKey(nameof(Cours.Id));
                },
                left =>
                {
                    return left.HasOne(typeof(Etudiant)).WithMany().HasForeignKey("EtudiantId").HasPrincipalKey(nameof(Etudiant.Id));
                },
                config =>
                {
                    config.ToTable("CoursEtudiants").HasKey("EtudiantId", "CoursId");
                    config.HasData(
                            new { EtudiantId = 1, CoursId = 1 },
                            new { EtudiantId = 2, CoursId = 2 }
                        );
                });
    }


}
