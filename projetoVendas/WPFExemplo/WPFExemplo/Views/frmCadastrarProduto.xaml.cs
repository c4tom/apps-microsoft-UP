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

namespace WPFExemplo.Views
{
    /// <summary>
    /// Interaction logic for frmCadastrarProduto.xaml
    /// </summary>
    public partial class frmCadastrarProduto : Window
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrarProduto_Click(object sender, RoutedEventArgs e)
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Campo vazio!");
            }
            else
            {
                string mensagem = txtNome.Text;
                MessageBox.Show(mensagem);
            }
        }

        private void txtNome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
