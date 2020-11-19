using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nest;
using SecretariaDeEscuelas.Models;

namespace SecretariaDeEscuelas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CarreraMateria>().HasKey(x => new { x.CarreraId, x.MateriaId });
            modelBuilder.Entity<MateriaEstudiante>().HasKey(y => new { y.MateriaId, y.EstudianteId, y.CalificacionId });
            modelBuilder.Entity<MateriaEstudiante>().HasOne(c => c.Calificacion).WithMany().OnDelete(DeleteBehavior.Restrict);

        }

        public DbSet<Instituto> Institutos { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<CarreraMateria> CarrerasMaterias { get; set; }
        public DbSet<Maestro> Maestros { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<MateriaEstudiante> MateriasEstudiantes { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }



    }
}
