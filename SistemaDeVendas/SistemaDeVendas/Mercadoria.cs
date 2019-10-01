using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas
{
    public class Mercadoria
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public Boolean Cadarso { get; set; }
        public string Material { get; set; }
        public string Cor { get; set; }
        public decimal Preco { get; set; }
        public string Imagem { get; set; }
        public IList<Grade> Grade { get; set; }
    }
}
