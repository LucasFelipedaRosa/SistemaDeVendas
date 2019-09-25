using SistemaDeVendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendasWPF.DAO
{
    public class PessoasDAO
    {
        //ModelVendas context = new ModelVendas();
        public static IList<Pessoa> ListaDePessoas = new List<Pessoa>();

        // public static IList<Pessoa> ListaDePessoas2 { get; private set; }

        public static IList<Pessoa> RetornarPessoas()
        {
            ModelVendas context = new ModelVendas();
            ListaDePessoas = context.Pessoas.ToList();
            return ListaDePessoas.ToList();
        }
        /*
        public static Pessoa RetornarPessoas2(ModelVendas context)
        {
            ListaDePessoas2 = context.Pessoas.ToList();
            return ListaDePessoas2.ToList();
        }
        */
    }
}
