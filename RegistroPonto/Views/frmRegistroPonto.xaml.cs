using System.Windows;

namespace RegistroPonto.Views
{
    /// <summary>
    /// Lógica interna para frmRegistroPonto.xaml
    /// </summary>
    public partial class frmRegistroPonto : Window
    {
        public frmRegistroPonto()
        {
            InitializeComponent();
        }


        private void BtnRegistrarPonto(object sender, RoutedEventArgs e)
        {
            // Adiciona registro ao banco de dados e mostra o valor no grid

            MessageBox.Show("Registro realizado com sucesso!", "Info", MessageBoxButton.OK);
        }
    }
}
