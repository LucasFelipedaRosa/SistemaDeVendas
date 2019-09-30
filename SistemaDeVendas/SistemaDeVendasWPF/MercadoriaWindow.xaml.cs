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
    /// Lógica interna para MercadoriaWindow.xaml
    /// </summary>
    public partial class MercadoriaWindow : Window
    {
        public MercadoriaViewModel MercadoriaViewModel { get; set; }
        public MercadoriaWindow()
        {
            InitializeComponent();
            this.MercadoriaViewModel = new MercadoriaViewModel();
            DataContext = this.MercadoriaViewModel;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == this.OkBtn)
            {
                this.MercadoriaViewModel.Salvar();
            }
            this.Close();
        }
    }
    
}
