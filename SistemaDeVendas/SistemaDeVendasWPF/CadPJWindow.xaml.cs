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
    /// Lógica interna para ClientePjWindow.xaml
    /// </summary>
    public partial class ClientePjWindow : Window
    {
        public ClientePjWindow ClientePjWindows { get; set; }

        public ClientePjWindow()
        {
            InitializeComponent();
            this.ClientePjWindows = new ClientePjWindow();
            DataContext = this.ClientePjWindows;
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (sender == this.CancelarBtn2)
            {
                this.ClientePjWindows.Salvar();
            }
            this.Close();
        }


    }
}
