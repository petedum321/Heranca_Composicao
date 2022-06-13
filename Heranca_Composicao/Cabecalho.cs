using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Composicao
{
    class Cabecalho
    {
        public Guid NumeroNota { get; set; }

        public Cliente Cliente { get; set; }

        public override string ToString()
        {
            StringBuilder cabecalho = new StringBuilder();
            cabecalho.AppendLine($"Número: {NumeroNota}");
            cabecalho.AppendLine($"Cliente: {Cliente.Nome}");
            if (Cliente is PessoaFisica)
                cabecalho.AppendLine($"CPF: {(Cliente as PessoaFisica).Cpf}");

            else
                cabecalho.AppendLine($"CNPJ: {(Cliente as PessoaJuridica).Cnpj}");

            return cabecalho.ToString();
        }

    }
}
