using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas
{
    public class PessoaJuridica : Pessoa 
    {
        public string Cnpj { get; set; }
        public Endereco Endereco { get; set; }
    }
}
