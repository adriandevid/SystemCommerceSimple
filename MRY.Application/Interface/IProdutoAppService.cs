using MRY.Domain.Models;

namespace MRY.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        Produto ProdutoSelecionado { get; set; }
        void Cadastrar(string nome, decimal Quantidade, int Valor, string DataValidade, string DataEstoque, int ICMS);
        bool VerificProdutoPorNome(string name);
        void GerarRelatorioDeProdutosCSV();
    }
}