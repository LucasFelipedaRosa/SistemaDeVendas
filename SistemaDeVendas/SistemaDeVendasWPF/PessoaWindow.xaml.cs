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
    /// Lógica interna para PessoaWindow.xam
    /// </summary>
    public partial class PessoaWindow : Window
    {
        public PessoaViewModel vmPessoa { get; set; }
        public PessoaWindow()
        {
            vmPessoa = new PessoaViewModel();
            InitializeComponent();
            this.DataContext = vmPessoa;
        }

        private void PessoasDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pessoa p = vmPessoa.PessoaSelecionada;
            UserControl page = PessoaViewFactory.VisualizarPessoa(p);
            while (PessoaContent.Children.Count > 0)
            {
                PessoaContent.Children.RemoveAt(0);
            }
            PessoaContent.Children.Add(page);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == this.OkBtn)
            {
                this.vmPessoa.Editar(vmPessoa.PessoaSelecionada);
            }
            else if (sender == this.Excluir_btn)
            {
                this.vmPessoa.Excluir(vmPessoa.PessoaSelecionada);
            }
            this.Close();
        }

    }

    public class PessoaViewFactory
    {
        static public UserControl VisualizarPessoa(Pessoa pessoa)
        {

            if (pessoa is PessoaFisica)
            {
                var pg = new PessoaFisicaUC();
                pg.Pessoa = (PessoaFisica)pessoa;
                return pg;

            }
            else if (pessoa is PessoaJuridica)
            {
                var pg = new PessoaJuridicaUC();
                pg.Pessoa = (PessoaJuridica)pessoa;
                return pg;
            }
            return null;
        }
        
    }
}

