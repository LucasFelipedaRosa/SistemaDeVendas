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
        public MercadoriaViewModel vmMercadoria { get; set; }
        public MercadoriaWindow()
        {
            vmMercadoria = new MercadoriaViewModel();
            InitializeComponent();
            this.DataContext = vmMercadoria;
        }

        private void MercadoriasDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mercadoria m = vmMercadoria.MercadoriaSelecionada;
            UserControl page = MercadoriaViewFactory.VisualizarMercadoria(m);
            while (MercadoriaContent.Children.Count > 0)
            {
                MercadoriaContent.Children.RemoveAt(0);
            }
            MercadoriaContent.Children.Add(page);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == this.OkBtn)
            {
                this.vmMercadoria.Editar(vmMercadoria.MercadoriaSelecionada);
            }
            else if (sender == this.Excluirbtn)
            {
                this.vmMercadoria.Excluir(vmMercadoria.MercadoriaSelecionada);
            }
            this.Close();
        }
        public class MercadoriaViewFactory
        {
            static public UserControl VisualizarMercadoria(Mercadoria mercadoria)
            {
                var pg = new MercadoriaUC();
                pg.Mercadoria = (Mercadoria)mercadoria;
                return pg;
            }

        }
    }
}
