using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas
{
    public class Cliente
    {
        public int Id { get; set; }
        public Boolean PF { get; set; }
        public string Nome{ get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public Endereco Enderco { get; set; }
        public DateTime DataDeNascimento { get; set; }=DateTime.Now;
    }
}
