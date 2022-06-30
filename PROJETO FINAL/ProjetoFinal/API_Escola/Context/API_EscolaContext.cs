using Microsoft.EntityFrameworkCore;
using API_Escola.Models;

namespace API_Escola.Context
{
    public class API_EscolaContext : DbContext
    {
        public API_EscolaContext(DbContextOptions<API_EscolaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("Aluno");
            modelBuilder.Entity<Turma>().ToTable("Turma");
        }

        // Define comunicação com as tabelas do banco de dados
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Turma> Turma { get; set; }
    }
}
