using System;
using System.Collections.Generic;
using Autofac;
using MRY.Application.Interface;
using MRY.Domain.Models;
using MRY.Infrastructure.IOC;

namespace MRY.UI
{
    public class BalcaoWindow
    {
        private List<String> ListaDeProdutosAddQuantidade = new List<String>();
        public void BalcaoIncial(){
            Console.WriteLine("------balcao------");
            Console.WriteLine("1 - Fazer Compra \n" + 
                            "2 - voltar ao menu anterior \n");
            var OpcaoBalcao = Console.ReadLine();
            switch(Convert.ToInt32(OpcaoBalcao))
            {
                case 1:
                    Console.WriteLine("----Fazer Compra----");
                    Console.WriteLine("Para encerrar digite valor '0' e pressione duas vezes a tecla  'enter'...");
                    Console.WriteLine("Escreva o nome do produto e em seguida a quantidade: ");
                    BalcaoCompra();
                    break;
                case 2:
                    Program.Main();
                    break;
                default:
                    Console.WriteLine("Não é uma opção valida!!");
                    break;
            }
        }
        private void BalcaoCompra()
        {
            var NomeProd = Console.ReadLine();
            var QuanidadeProd = Console.ReadLine();

            while(Convert.ToString(NomeProd) != "0")
            {
                ListaDeProdutosAddQuantidade.Add(Convert.ToString(NomeProd));
                ListaDeProdutosAddQuantidade.Add(Convert.ToString(QuanidadeProd));

                NomeProd = Console.ReadLine();
                QuanidadeProd = Console.ReadLine();
            }
            var container = IoC.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IProdutoAppService>();
                for(int Count = 0; Count <= ListaDeProdutosAddQuantidade.Count - 1; Count++)
                {
                    List<Produto> ListProds = app.GetAll();
                    foreach (Produto produto in ListProds)
                    {
                        if (ListaDeProdutosAddQuantidade[Count] == produto.Nome)
                        {
                            produto.Quantidade = produto.Quantidade - Convert.ToInt32(ListaDeProdutosAddQuantidade[Count + 1]);
                            app.Update(produto);
                            app.SaveChanges();
                        }
                    }
                }
            }
            BalcaoIncial();
        }
    }
}