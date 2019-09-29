using System.Windows;

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
