using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SistemaDeVendas
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public DateTime DataDeNascimento { get; set; } = DateTime.Now;

    }
}
