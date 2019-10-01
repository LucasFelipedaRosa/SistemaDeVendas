using SistemaDeVendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendasWPF.ViewModel
{
    public class MercadoriaViewModel
    {
        public IList<Mercadoria> Mercadorias { get; set; }

        public Mercadoria MercadoriaSelecionada { get; set; }

        public SistemaDeVendas.Mercadoria Mercadoria { get; set; }

        protected ModelVendas context { get; set; } = new ModelVendas();

        public MercadoriaViewModel()
        {
            this.Mercadoria = new SistemaDeVendas.Mercadoria();
            this.Mercadorias = context.Mercadorias.ToList();
            this.Mercadoria = new SistemaDeVendas.Mercadoria();
            MercadoriaSelecionada = Mercadorias.FirstOrDefault();
        }

        public void Salvar()
        {
            this.context.Mercadorias.Add(Mercadoria);
            this.context.SaveChanges();
        }

        public void Editar(Mercadoria m)
        {
            this.context.SaveChanges();
        }
        public void Excluir(Mercadoria m)
        {
                context.Mercadorias.Remove(m);
                context.SaveChanges();
            
        }
    }
}
