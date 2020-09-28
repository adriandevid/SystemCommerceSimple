using System;
using Autofac;
using MRY.Application.Interface;
using MRY.Infrastructure.IOC;

namespace MRY.UI
{
    public class EstoqueWindow
    {
        public void Estoque(){
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Balcao: ");
            Console.WriteLine("Digite o numero das opções que desejar: \n" + "1 - Relatorio Em Modo CSV \n " + "2 - Relatorio em modo PDF \n " + "3 - Voltar ao menu anterior \n " + "4 - Adicionar produto");
            var OpcaoBalcao =  Console.ReadLine();
            switch (Convert.ToInt32(OpcaoBalcao))
            {
                case 1:
                    GerarRelatorioCSV();
                    break;
                case 2:
                    GerarReatorioPDF();
                    break;
                case 3:
                    Program.Main();
                    break;
                case 4:
                    CadastrarProduto();
                    break;
                default:
                    break;
            }
        }
        private void GerarRelatorioCSV()
        {
            Console.WriteLine("-------------------------------------------");
            var Container = IoC.Configure();
            using(var Scope = Container.BeginLifetimeScope()){
                var app = Scope.Resolve<IProdutoAppService>();
                app.GerarRelatorioDeProdutosCSV();
            }
            Estoque();
        }
        private void GerarReatorioPDF(){
            Console.WriteLine("-------------------------------------------");
            var Container = IoC.Configure();
            using(var Scope = Container.BeginLifetimeScope()){
                var app = Scope.Resolve<IProdutoAppService>();
                app.GerarRelatorioDeProdutosPDF();
            }
            Estoque();
        }
        private void CadastrarProduto(){
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Cadastrar Produto: ");
            Console.WriteLine("Nome: ");
            var ProdName = Console.ReadLine();
            Console.WriteLine("Quantidade: ");
            var ProdQuantidade = Console.ReadLine();
            Console.WriteLine("Valor Por Unidade: ");
            var ProdValorUnidade = Console.ReadLine();


            var Container = IoC.Configure();
            using(var Scope = Container.BeginLifetimeScope()){
                var app = Scope.Resolve<IProdutoAppService>();
                app.Cadastrar(ProdName, Convert.ToInt32(ProdQuantidade), Convert.ToInt32(ProdValorUnidade), Convert.ToString(DateTime.Now), Convert.ToString(DateTime.Now), 15);
            }
            Estoque();
        }
    }
}