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
        public SistemaDeVendas.ClientePf ClientePf { get; set; }


        ModelVendas context = new ModelVendas();

        public ClienteViewModel()
        {
            this.ClientePf = new SistemaDeVendas.ClientePf();           
        }



        public void Salvar()
        {
            this.context.Clientes.Add(ClientePf);
           this.context.SaveChanges();
        }
    }
}
