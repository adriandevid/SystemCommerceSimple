using Microsoft.EntityFrameworkCore;
using MRY.Domain.Models;

namespace MRY.Infrastructure.DataAcesss.Context
{
    public class ProdutoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\PC\\source\\repos\\MRY\\MRY.Infrastructure.DataAcesss\\DataBase\\DbProdForn.db");
        }
        protected override void OnModelCreating(ModelBuilder options)
        {
            options.Entity<Produto>().HasKey(produto => produto.ProdutoId);
            options.Entity<Fornecedor>().HasKey(fornecedor => fornecedor.FornecedorId);
        }
    }
}
