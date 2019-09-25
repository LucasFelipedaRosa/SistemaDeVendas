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
    /// Lógica interna para CadPFWindow.xaml
    /// </summary>
    public partial class CadPFWindow : Window
    {
        public PessoaViewModel ClienteViewModel { get; set; }
        public Pessoa Pessoa { get; set; }

        public CadPFWindow()
        {
            InitializeComponent();
            this.ClienteViewModel = new PessoaViewModel();
            DataContext = this.ClienteViewModel;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == this.OkBtn)
            {    
                this.ClienteViewModel.Salvar();
            }
            this.Close();
        }
    }
}
