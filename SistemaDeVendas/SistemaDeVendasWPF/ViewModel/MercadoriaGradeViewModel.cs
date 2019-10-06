using SistemaDeVendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendasWPF.ViewModel
{
    public class MercadoriaGradeViewModel
    {
        public SistemaDeVendas.Grade Grade { get; set; }
        public Grade GradeSelecionada { get; set; }
        public IList<Grade> GradesSelecionadas { get; set; }
        protected ModelVendas context { get; set; } = new ModelVendas();


        public MercadoriaGradeViewModel()
        {
            this.Grade = new SistemaDeVendas.Grade();
            this.GradesSelecionadas = context.Grades.ToList();
            GradeSelecionada = GradesSelecionadas.FirstOrDefault();
        }

        public void Editar(Grade g)
        {
            this.context.SaveChanges();
        }
        public void Excluir(Grade g)
        {
            context.Grades.Remove(g);
            context.SaveChanges();

        }
    }
}
