using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Composicao
{
    class NotaFiscal
    {
        public Cabecalho Cabecalho { get; set; }
        public List<Produto> Produtos { get; set; }
        public Rodape Rodape { get; set; }

        public void Imprimir()
        {
            Console.WriteLine("**************************      NOTA FISCAL DE SAIDA      **************************\n\n\n");
            
            Console.WriteLine(Cabecalho);
            Console.WriteLine("\n\n\n");

            string produto = "Produto";
            string quantidade = "Quantidade";
            string preco = "Preço";

            Console.WriteLine($"{produto.PadRight(27)}{quantidade.PadRight(20)}{preco.PadRight(20)}");
            foreach (Produto p in Produtos)
            {
                Console.WriteLine($"{p.Nome.PadRight(15)}               {p.Quantidade.ToString().PadRight(8)}          R${p.Preco.ToString().PadRight(5)}\n\n\n");
            }

            Console.WriteLine(Rodape);
            Console.WriteLine("\n\n\n");
            Console.WriteLine("************************************************************************************");
        }

    }
}
