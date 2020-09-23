
using MRY.Application.Interface;
using MRY.Domain.Abstracts.Service;
using MRY.Domain.Models;
using System.Collections.Generic;

namespace MRY.Application
{
    public class ProdutoApplication : IProdutoAppService
    {
        public Produto ProdutoSelecionado { get; set; }
        public IProdutoService _produtoService { get; set; }
        public ProdutoApplication(IProdutoService ProdutoRepository)
        {
            _produtoService = ProdutoRepository;
        }

        public void Cadastrar(string nome, decimal Quantidade, int Valor, string DataValidade, string DataEstoque, int ICMS)
        {
            _produtoService.Cadastrar(nome, Quantidade, Valor, DataValidade, DataEstoque, ICMS);
        }

        public bool VerificProdutoPorNome(string name)
        {
            return _produtoService.VerificProdutoPorNome(name);
        }

        public void GerarRelatorioDeProdutosCSV()
        {
            _produtoService.GerarRelatorioDeProdutosCSV();
        }

        public void Add(Produto obj)
        {
            _produtoService.Add(obj);
        }


        public List<Produto> GetAll()
        {
            return _produtoService.GetAll();
        }

        public void Update(Produto obj)
        {
            _produtoService.Update(obj);
        }

        public void Remove(Produto obj)
        {
            _produtoService.Remove(obj);
        }

        public void SaveChanges()
        {
            _produtoService.SaveChanges();
        }

        public void GerarRelatorioDeProdutosPDF()
        {
            _produtoService.GerarRelatorioDeProdutosPDF();
        }
    }
}