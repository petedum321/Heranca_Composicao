using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Composicao
{
    class Rodape
    {
        public decimal ValorTotal { get; set; }

        public override string ToString()
        {
            return $"Total da nota fiscal: R$ {ValorTotal}";
        }
    }
}
