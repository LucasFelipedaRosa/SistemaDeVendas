using SistemaDeVendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
           this.Mercadorias = context.Mercadorias.Include("Grade").ToList();
           MercadoriaSelecionada = Mercadorias.FirstOrDefault();
        }

        public void Salvar()
        {
            var result = (from merc in context.Mercadorias
                          where Mercadoria.Modelo == merc.Modelo
                          select merc).FirstOrDefault();
            if (result == null)
            {
                this.context.Mercadorias.Add(Mercadoria);
                this.context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Mercadoria já cadastrada");
            }
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
