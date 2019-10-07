using SistemaDeVendas;
using SistemaDeVendasWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SistemaDeVendasWPF
{
    /// <summary>
    /// Interação lógica para GradeViewUC.xam
    /// </summary>
    public partial class GradeViewUC : UserControl
    {
        public IList<Grade> GradesSelecionadas { get; set; }
        public MercadoriaGradeViewModel MercadoriaGradeViewModel { get; set; }
        public GradeViewUC()
        {
            InitializeComponent();
            MercadoriaGradeViewModel = new MercadoriaGradeViewModel();
            this.DataContext = this;
        }
        private void GradesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                Grade g= MercadoriaGradeViewModel.GradeSelecionada;
                UserControl page = PessoaViewFactory.VisualizarGrade(g);
                while (MercadoriaContent.Children.Count > 0)
                {
                    MercadoriaContent.Children.RemoveAt(0);
                }
                MercadoriaContent.Children.Add(page);

        }
        public class PessoaViewFactory
        {
            static public UserControl VisualizarGrade(Grade grade)
            {
                var pg = new GradeAltUC();
                pg.GradeSelecionada = (Grade)grade;
                return pg;
            }

        }

    }
    
}
