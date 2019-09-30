using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas
{
    public class ClientePj : Cliente
    {
        public string Cnpj { get; set; }
        public Endereco Enderco { get; set; }
    }
}
