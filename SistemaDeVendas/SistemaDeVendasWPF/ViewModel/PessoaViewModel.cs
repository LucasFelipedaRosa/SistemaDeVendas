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
        public IList<Pessoa> Pessoas { get; set; }
        = DAO.PessoasDAO.RetornarPessoas();

        public Pessoa PessoaSelecionada { get; set; }

        ModelVendas context = new ModelVendas();

        public PessoaViewModel()
        {
            this.PessoaFisica = new SistemaDeVendas.PessoaFisica(); 
            PessoaSelecionada = Pessoas.FirstOrDefault();
        }



        public void Salvar()
        {
            this.context.Pessoas.Add(PessoaFisica);
           this.context.SaveChanges();
        }
    }
}
