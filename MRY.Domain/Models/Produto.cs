using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MRY.Domain.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Quantidade { get; set; }
        public int Valor { get; set; }
        public string DataDeValidade { get; set; }
        public string DataEstoque { get; set; }
        public int ICMS { get; set; }
        public List<Fornecedor> Fornecedores { get; set; }

        public void CalculoICMS()
        {

        }
    }
}
