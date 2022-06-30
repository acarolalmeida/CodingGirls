using Agenda.Models;
using Microsoft.EntityFrameworkCore;

// ENTITY FRAMEWORK - LIGA MODEL AO BANCO DE DADOS

namespace Agenda.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>().ToTable("Contato");
            //modelBuilder.Entity<Contato>().ToTable("Usuário");
        }

        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Usuario> Usuario { get; set; } 
    }
}
