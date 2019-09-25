using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas
{
    class Venda
    {
        public int Id { get; set; }
        public int QuantidadeItens { get; set; }
        public IList<Mercadoria> Mercadorias { get; set; }
        public IList<Grade> Grade { get; set; }
        public Pessoa Pessoa { get; set; }
        public DateTime DataDaVenda { get; set; }
    }
}
