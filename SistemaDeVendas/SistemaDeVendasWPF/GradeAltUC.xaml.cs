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
    /// Interação lógica para GradeAlt.xam
    /// </summary>
    public partial class GradeAltUC : UserControl
    {
        public MercadoriaGradeViewModel MercadoriaGradeViewModel { get; set; }
        public Grade GradeSelecionada { get; set; }
        public Grade Grade { get; set; }
        public GradeAltUC()
        {
            MercadoriaGradeViewModel = new MercadoriaGradeViewModel();
            InitializeComponent();
            this.DataContext = MercadoriaGradeViewModel;
        }
    }
}
