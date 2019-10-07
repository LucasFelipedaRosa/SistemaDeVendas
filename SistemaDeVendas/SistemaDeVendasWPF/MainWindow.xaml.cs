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
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CadastrarClienteMenu_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CadPFWindow();
            window.ShowDialog();
        }

        private void VisualizarClienteMenu_Click(object sender, RoutedEventArgs e)
        {
            PessoaWindow window = new PessoaWindow();
            window.ShowDialog();
        }

        private void CadastrarMercadoriaMenu_Click(object sender, RoutedEventArgs e)
        {
            CadMercadoriaWindow window = new CadMercadoriaWindow();
            window.ShowDialog();
        }

        private void CadastrarClienteMenu2_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CadPJWindow();
            window.ShowDialog();
           
        }

        private void VisualizarMercadoriaMenu_Click(object sender, RoutedEventArgs e)
        {
            MercadoriaWindow window = new MercadoriaWindow();
            window.ShowDialog();
        }

        private void CadastrarGradeMenu_Click(object sender, RoutedEventArgs e)
        {
            CadGradeWindow window = new CadGradeWindow();
            window.ShowDialog();
        }
    }
}
