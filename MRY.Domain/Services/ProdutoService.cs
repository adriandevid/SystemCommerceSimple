using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MRY.Domain.Abstracts.Repository;
using MRY.Domain.Abstracts.Service;
using MRY.Domain.Models;

namespace MRY.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        public Produto ProdutoSelecionado { get; set; }
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository ProdutoRepository)
        {
            _produtoRepository = ProdutoRepository;
        }
        public void Add(Produto obj)
        {
            _produtoRepository.Add(obj);
        }
        public List<Produto> GetAll()
        {
            return _produtoRepository.GetAll();
        }

        public void Remove(Produto obj)
        {
            _produtoRepository.Remove(obj);
        }

        public void Update(Produto obj)
        {
            _produtoRepository.Update(obj);
        }
        public void Cadastrar(string nome, decimal Quantidade, int Valor, string DataValidade, string DataEstoque, int ICMS)
        {
            _produtoRepository.Add(new Produto
            {
                Nome = nome,
                Valor = Valor,
                DataDeValidade = DataValidade,
                DataEstoque = DataEstoque,
                ICMS = ICMS,
                Fornecedores = { }
            });
        }

        public bool VerificProdutoPorNome(string name)
        {
            bool VerificProdState = false;
            List<Produto> ListProds = _produtoRepository.GetAll();
            foreach (Produto produto in ListProds)
            {
                ProdutoSelecionado = produto;
                if (name == produto.Nome)
                {
                    return VerificProdState = true;
                }
            }
            return VerificProdState;
        }

        public void GerarRelatorioDeProdutosCSV()
        {
            List<Produto> ListProds = _produtoRepository.GetAll();
            StringBuilder CsvCompenete = new StringBuilder();
            CsvCompenete.AppendLine(",Nome,Quantidade,valor");
            foreach (Produto produto in ListProds)
            {
                string EstruturaProd = String.Format("{0},{1},{2},{3}", produto.ProdutoId, produto.Nome, produto.Quantidade, produto.Valor);
                CsvCompenete.AppendLine(EstruturaProd);
            }
            string EstruturaPath = String.Format("C:\\Users\\PC\\documents\\Relatorio-{0}.csv", DateTime.Now);
            File.AppendAllText(EstruturaPath, CsvCompenete.ToString());
        }

        public void SaveChanges()
        {
            _produtoRepository.SaveChanges();
        }

        public void GerarRelatorioDeProdutosPDF()
        {
            List<Produto> ListaDeProdutos = _produtoRepository.GetAll();

            Document document  = new Document(PageSize.A4);
            document.SetMargins(3, 2, 3, 2);
            PdfWriter writer1 = PdfWriter.GetInstance(document, new FileStream(
                Directory.GetCurrentDirectory() + "\\NomeArquivo.pdf", FileMode.Create
            ));
            Console.WriteLine(Directory.GetCurrentDirectory());
            document.Open();

            PdfPTable table = new PdfPTable(3);

            Font fonte = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 22);

            Paragraph Coluna1 = new Paragraph("ID", fonte);
            Paragraph Coluna2 = new Paragraph("Nome", fonte);
            Paragraph Coluna3 = new Paragraph("Quantidade", fonte);
            Paragraph Coluna4 = new Paragraph("Valor Unidade", fonte);

            var Cell1 = new PdfPCell();
            var Cell2 = new PdfPCell();
            var Cell3 = new PdfPCell();
            var Cell4 = new PdfPCell();

            Cell1.AddElement(Coluna1);
            Cell2.AddElement(Coluna2);
            Cell3.AddElement(Coluna3);
            Cell4.AddElement(Coluna4);

            table.AddCell(Cell1);
            table.AddCell(Cell2);
            table.AddCell(Cell3);
            table.AddCell(Cell4);
            
            document.Add(table);
            document.Close();
        }
    }
}