using SistemaDeVendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendasWPF.ViewModel
{
    public class GradeViewModel
    {
        public Grade GradeSelecionada { get; set; }

        public Mercadoria MercadoriaSelecionada { get; set; }

        public IList<Mercadoria> Mercadorias { get; set; }

        public IList<Grade> Grades {get;set;}

        public SistemaDeVendas.Mercadoria Mercadoria { get; set; }

        public SistemaDeVendas.Grade Grade { get; set; }

        protected ModelVendas context { get; set; } = new ModelVendas();
     

        public GradeViewModel()
        {
            this.Grades = new List<Grade>();
            this.Mercadoria = new SistemaDeVendas.Mercadoria();
            this.Grade = new SistemaDeVendas.Grade();
            this.Mercadorias = context.Mercadorias.ToList();
            MercadoriaSelecionada = Mercadorias.FirstOrDefault();
        }
        public void Salvar()
        {
            Grades.Add(Grade);
            this.MercadoriaSelecionada.Grade = Grades;
            this.context.SaveChanges();
        }
    }
}
