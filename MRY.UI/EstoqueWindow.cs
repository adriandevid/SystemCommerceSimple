using System;
using Autofac;
using MRY.Application.Interface;
using MRY.Infrastructure.IOC;

namespace MRY.UI
{
    public class EstoqueWindow
    {
        public void Estoque(){
            Console.WriteLine("Balcao: ");
            Console.WriteLine("Digite o numero das opções que desejar: \n" + "1 - Relatorio Em Modo CSV \n " + "2 - Relatorio em modo PDF \n " + "3 - Voltar ao menu anterior \n ");
            var OpcaoBalcao =  Console.ReadLine();
            switch (Convert.ToInt32(OpcaoBalcao))
            {
                case 1:
                    GerarRelatorioCSV();
                    break;
                case 2:
                    break;
                case 3:
                    Program.Main();
                    break;
                default:
                    break;
            }
        }
        private void GerarRelatorioCSV()
        {
            var Container = IoC.Configure();
            using(var Scope = Container.BeginLifetimeScope()){
                var app = Scope.Resolve<IProdutoAppService>();
                app.GerarRelatorioDeProdutosCSV();
            }
            Estoque();
        }
        private void GerarReatorioPDF(){
            //implementar Serviço de dominio para Relatorio em formarto pdf
        }
    }
}