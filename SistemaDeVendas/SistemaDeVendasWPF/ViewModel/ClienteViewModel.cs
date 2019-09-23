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
        ModelVendas context = new ModelVendas();
        public void Salvar()
        {
           this.context.SaveChanges();
        }
    }
}
