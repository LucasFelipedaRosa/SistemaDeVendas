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
        public SistemaDeVendas.Mercadoria Mercadoria { get; set; }
        //public IList<Pessoa> Pessoas { get; set; }
        //= DAO.PessoasDAO.RetornarPessoas();

        //public Pessoa PessoaSelecionada { get; set; }
        
        ModelVendas context = new ModelVendas();

        public MercadoriaViewModel()
        {
            this.Mercadoria = new SistemaDeVendas.Mercadoria();
            //PessoaSelecionada = Pessoas.FirstOrDefault();
        }

        public void Salvar()
        {
            this.context.Mercadorias.Add(Mercadoria);
            this.context.SaveChanges();
        }
    }
}
