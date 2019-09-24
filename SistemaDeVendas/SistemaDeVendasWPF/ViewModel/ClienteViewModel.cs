using SistemaDeVendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendasWPF.ViewModel
{
    public class ClienteViewModel
    {
        public SistemaDeVendas.Cliente Cliente { get; set; }


        ModelVendas context = new ModelVendas();

        public ClienteViewModel()
        {
            this.Cliente = new SistemaDeVendas.Cliente();
        }

        

        public void Salvar()
        {
            this.context.Clientes.Add(Cliente);
           this.context.SaveChanges();
        }
    }
}
