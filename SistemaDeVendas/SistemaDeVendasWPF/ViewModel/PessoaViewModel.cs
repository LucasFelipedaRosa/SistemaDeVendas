using SistemaDeVendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendasWPF.ViewModel
{
    public class PessoaViewModel
    {
        public SistemaDeVendas.PessoaFisica PessoaFisica { get; set; }
        public SistemaDeVendas.PessoaJuridica PessoaJuridica { get; set; }
        public IList<Pessoa> Pessoas { get; set; }

        public Pessoa PessoaSelecionada { get; set; }

        public SistemaDeVendas.Pessoa Pessoa { get; set; }

        protected ModelVendas context { get; set; } = new ModelVendas();

        public PessoaViewModel()
        {
            this.Pessoas = context.Pessoas.ToList();
            this.Pessoa = new SistemaDeVendas.Pessoa();
            this.PessoaFisica = new SistemaDeVendas.PessoaFisica();
            this.PessoaJuridica = new SistemaDeVendas.PessoaJuridica();
            PessoaSelecionada = Pessoas.FirstOrDefault();
        }

        public void Salvar()
        {
            this.context.Pessoas.Add(PessoaFisica);
            this.context.Pessoas.Add(PessoaJuridica);
            this.context.SaveChanges();
        }
        public void Editar(Pessoa p)
        {
            this.context.SaveChanges();
        }
        public void Excluir(Pessoa p)
        {
                context.Pessoas.Remove(p);
                context.SaveChanges();
           
        }
    }
}
