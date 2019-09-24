using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas
{
    class PessoaFisica : Cliente
    {
        public string Cpf { get; set; }
        public DateTime DataDeNascimento { get; set; } = DateTime.Now;

    }
}
