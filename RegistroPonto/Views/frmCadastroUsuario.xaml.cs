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

namespace RegistroPonto.Views
{
    /// <summary>
    /// Lógica interna para frmCadastroUsuario.xaml
    /// </summary>
    public partial class frmCadastroUsuario : Window
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void BtnCadastrarUsuario(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Registro realizado com sucesso!", "Info", MessageBoxButton.OK);
        }

        private void BtnClickNovoRegistro(object sender, RoutedEventArgs e)
        {
            // Limpar todos os campos

        }
    }
}
