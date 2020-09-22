using Microsoft.EntityFrameworkCore;
using MRY.Domain.Models;

namespace MRY.Infrastructure.DataAcesss.Context
{
    public class UsuarioContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<NivelDeAcesso> NiveisDeAcesso { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\PC\\source\\repos\\MRY\\MRY.Infrastructure.DataAcesss\\DataBase\\DbUsuarioAcess.db");
        }
        protected override void OnModelCreating(ModelBuilder options)
        {
            options.Entity<Usuario>().HasKey(usuario => usuario.UsuarioId);
            options.Entity<NivelDeAcesso>().HasKey(nivel => nivel.NivelDeAcessoId);
        }
    }
}
