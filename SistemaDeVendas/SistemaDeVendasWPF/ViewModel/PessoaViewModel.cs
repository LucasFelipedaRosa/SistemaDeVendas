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

        public SistemaDeVendas.Pessoa Pessoa { get; set; }

        ModelVendas context = new ModelVendas();

        public PessoaViewModel()
        {
            this.Pessoa = new SistemaDeVendas.Pessoa();
            this.PessoaFisica = new SistemaDeVendas.PessoaFisica();
            PessoaSelecionada = Pessoas.FirstOrDefault();
        }

        public void Salvar()
        {
            this.context.Pessoas.Add(PessoaFisica);
           this.context.SaveChanges();
        }
        public void Editar(Pessoa p)
        {
            if (p is PessoaJuridica)
            {
                PessoaJuridica pessoaJuridica = (from pss in context.PessoaJuridicas
                                                 where pss.Id == p.Id
                                                 select pss).FirstOrDefault();
                if (pessoaJuridica != null)
                {
                    pessoaJuridica.Nome = p.Nome;
                    this.context.SaveChanges();
                }
            } else if (p is PessoaFisica)
            {               
                PessoaFisica pessoaFisica = (from pss in context.PessoaFisicas
                                             where pss.Id == p.Id
                                             select pss).FirstOrDefault();
                if (pessoaFisica != null)
                {
                    pessoaFisica.Nome = p.Nome;
                    this.context.SaveChanges();
                }
            }
        }
        public void Excluir(Pessoa p)
        {
            Pessoa pessoa = (from pss in context.Pessoas
                                         where pss.Id == p.Id
                                         select pss).FirstOrDefault();
            if (Pessoa != null)
            {
                context.Pessoas.Remove(pessoa);
                context.SaveChanges();
            }
        }
    }
}
