using System;

namespace MRY.UI
{
    static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ola!! Bem-vindo ao sistema de venda e gerenciamento de produtos.");
            Console.WriteLine("Escolha uma das opções abaixo:\n"+
                                    "1 - Balcao\n"+
                                "2 - Estoque\n"+
                                "3 - Encerrar");
            var resposta = Console.ReadLine();
            switch (Convert.ToInt32(resposta))
            {
                case 1: 
                    new BalcaoWindow().BalcaoIncial();
                    break;
                case 2: 
                    new EstoqueWindow().Estoque();
                    break;
                case 3: 
                    Environment.Exit(0);
                    break; 
                default: 
                    Console.WriteLine("op 1"); 
                    break;
            }
            Console.WriteLine("----------------------------------");
        }
    }
}
