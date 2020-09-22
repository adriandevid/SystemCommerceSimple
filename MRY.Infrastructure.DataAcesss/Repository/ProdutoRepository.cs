using Microsoft.EntityFrameworkCore;
using MRY.Domain.Abstracts;
using MRY.Domain.Abstracts.Repository;
using MRY.Domain.Models;
using MRY.Infrastructure.DataAcesss.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MRY.Infrastructure.DataAcesss.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        public ProdutoContext _contextProduto { get; set; }
        public ProdutoRepository(ProdutoContext ContextProduto)
        {
            _contextProduto = ContextProduto;
        }

        public List<Produto> GetAll()
        {
            IQueryable<Produto> query = _contextProduto.Produtos.Include(usuario => usuario.Fornecedores);
            return query.ToList();
        }

        public void Add(Produto obj)
        {
            _contextProduto.Add(obj);
        }

        public void Update(Produto obj)
        {
            _contextProduto.Update(obj);
        }

        public void Remove(Produto obj)
        {
            _contextProduto.Remove(obj);
        }

        public void SaveChanges()
        {
            _contextProduto.SaveChanges();
        }
    }
}
