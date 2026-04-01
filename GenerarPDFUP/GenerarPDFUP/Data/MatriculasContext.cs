using GenerarPDFUP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPDFUP.Data
{
 
    public class MatriculasContext : DbContext
    {
        public MatriculasContext(DbContextOptions<MatriculasContext> options)
            : base(options) { }

        
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Encargado> Encargados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ResultadoDto> ResultadoDto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ResultadoDto>().HasNoKey();
        }

    }

}
