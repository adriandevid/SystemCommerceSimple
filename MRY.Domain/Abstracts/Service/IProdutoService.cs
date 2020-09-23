using MRY.Domain.Models;

namespace MRY.Domain.Abstracts.Service
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        Produto ProdutoSelecionado { get; set; }
        void Cadastrar(string nome, decimal Quantidade, int Valor, string DataValidade, string DataEstoque, int ICMS);
        bool VerificProdutoPorNome(string name);
        void GerarRelatorioDeProdutosCSV();
        void GerarRelatorioDeProdutosPDF();
    }
}