using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas
{
    public class Mercadoria
    {
        public int id { get; set; }
        public Boolean Cadarso { get; set; }
        public string Material { get; set; }
        public string Cor { get; set; }
        public decimal Preco { get; set; }
        public string Imagem { get; set; }
    }
}
