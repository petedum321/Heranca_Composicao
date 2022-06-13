using System;
using System.Collections.Generic;

namespace Heranca_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente clienteA = new PessoaFisica() { Nome = "Enzo", Cpf = "239.400.058-93" };
            Cliente clienteB = new PessoaJuridica() { Nome = "SEPalmeiras", Cnpj = "61.750.345/0001-57" };


            List<Produto> produtosA = new List<Produto>()
            {
                new Produto(){ Nome = "Cabeça Fria, Coração Quente", Preco = 79M, Quantidade = 2},
                new Produto(){ Nome = "Xícara", Preco = 10.5M, Quantidade = 1},
                new Produto(){ Nome = "Camiseta", Preco = 150.0M, Quantidade = 3},
            };

            List<Produto> produtosB = new List<Produto>()
            {
                new Produto(){ Nome = "Bola de futebol", Preco = 100.00M, Quantidade = 10},
                new Produto(){ Nome = "Chuteira", Preco = 450.0M, Quantidade = 23},
                new Produto(){ Nome = "Miniatura Libertadores", Preco = 79.50M, Quantidade = 3},

            };

            NotaFiscal notaFiscalA= GeraNotas(clienteA,produtosA);
            notaFiscalA.Imprimir();

            Console.WriteLine();
            NotaFiscal notaFiscalB = GeraNotas(clienteB, produtosB);
            notaFiscalB.Imprimir();
        }

        static NotaFiscal GeraNotas(Cliente cliente, List<Produto> produtos)
        {
            Cabecalho cabecalho = new Cabecalho() { NumeroNota = Guid.NewGuid(), Cliente = cliente };
            decimal valorTotal = 0;

            foreach (Produto produto in produtos)
                valorTotal += produto.Preco * produto.Quantidade;

            Rodape rodape = new Rodape() { ValorTotal = valorTotal };
            NotaFiscal notaFiscal = new NotaFiscal() { Cabecalho = cabecalho, Produtos = produtos, Rodape = rodape };
            return notaFiscal;
        }
    }
}
