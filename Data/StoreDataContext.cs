using Microsoft.EntityFrameworkCore;
using apiCiee.Models;
using apiCiee.Data.Maps;

namespace apiCiee.Data
{
    public class StoreDataContext : DbContext {
        public DbSet<Escola> Escolas { get; set; }
        public DbSet<Estudante> Estudante { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Cep> Cep { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
          
            optionsBuilder.UseMySql(@"Server=192.168.0.3;User Id=root;Password=goya@123;Database=test;TreatTinyAsBoolean=false");
            
        }
        protected override void OnModelCreating(ModelBuilder builder){
            if (builder is null)
            {
                throw new System.ArgumentNullException(nameof(builder));
            }

            builder.ApplyConfiguration(new EscolaMap());
            builder.ApplyConfiguration(new CepMap());
            builder.ApplyConfiguration(new EstudanteMap());
            builder.ApplyConfiguration(new CursoMap());
        }
    }
}