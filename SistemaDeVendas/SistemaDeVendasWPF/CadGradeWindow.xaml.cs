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
    /// Lógica interna para CadGrade.xaml
    /// </summary>
    public partial class CadGradeWindow : Window
    {
        //GradeViewModel vmGrade { get; set; }
        public GradeViewModel GradeViewModel { get; set; }
        public CadGradeWindow()
        {           
            InitializeComponent();
            this.GradeViewModel = new GradeViewModel();
            this.DataContext = GradeViewModel;
        }

        private void MercadoriasDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == this.OkBtn)
            {
                this.GradeViewModel.Salvar();
            }
            this.Close();
        }
    }
}
