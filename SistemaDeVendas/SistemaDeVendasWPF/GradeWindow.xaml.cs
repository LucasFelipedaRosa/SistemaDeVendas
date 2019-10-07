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
using System.Windows.Shapes;

namespace SistemaDeVendasWPF
{
    /// <summary>
    /// Lógica interna para GradeWindow.xaml
    /// </summary>
    public partial class GradeWindow : Window
    {
        public GradeViewModel GradeViewModel { get; set; }
        public MercadoriaGradeViewModel MercadoriaGradeViewModel { get; set; }
        public GradeWindow()
        {
            InitializeComponent();
            this.GradeViewModel = new GradeViewModel();
            this.MercadoriaGradeViewModel = new MercadoriaGradeViewModel();
            this.DataContext = GradeViewModel;
        }

        private void MercadoriasDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mercadoria m = GradeViewModel.MercadoriaSelecionada;
            UserControl page = PessoaViewFactory.VisualizarGrade(m);
            while (MercadoriaContent.Children.Count > 0)
            {
                MercadoriaContent.Children.RemoveAt(0);
            }
            MercadoriaContent.Children.Add(page);

        }
        public class PessoaViewFactory
        {
            static public UserControl VisualizarGrade(Mercadoria mercadoria)
            {
                var pg = new GradeViewUC();
                pg.GradesSelecionadas = mercadoria.Grade;
                return pg;
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == this.OkBtn)
            {
                this.MercadoriaGradeViewModel.Editar(MercadoriaGradeViewModel.GradeSelecionada);
            }
            else if (sender == this.Excluir_btn)
            {
                this.MercadoriaGradeViewModel.Excluir(MercadoriaGradeViewModel.GradeSelecionada);
            }
            this.Close();
        }

    }
}
