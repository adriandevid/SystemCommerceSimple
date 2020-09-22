using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MRY.Domain.Models
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public string Nome { get; set; }
        public string NomeEmpresa { get; set; }
        public string CPNJ { get; set; }
        public DateTime DataAfiliacao { get; set; }
        public string Endereco { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produtos { get; set; }
    }
}
