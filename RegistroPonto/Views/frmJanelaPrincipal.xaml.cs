using System.Windows;
namespace RegistroPonto.Views
{
    /// <summary>
    /// Lógica interna para frmJanelaPrincipal.xaml
    /// </summary>
    public partial class frmJanelaPrincipal : Window
    {
        public frmJanelaPrincipal()
        {
            InitializeComponent();
        }
        private void FecharJanelaPrincipal(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar a janela?", "Controle de Ponto",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
        private void BtnClickRegistrarPonto(object sender, RoutedEventArgs e)
        {
            frmRegistroPonto frm = new frmRegistroPonto();
            frm.ShowDialog();
        }
        private void MnClickCadastroUsuario(object sender, RoutedEventArgs e)
        {
            frmCadastroUsuario frm = new frmCadastroUsuario();
            frm.ShowDialog();
        }
        private void MnClickSobre(object sender, RoutedEventArgs e)
        {
            new frmSobre().ShowDialog();
        }
        private void MnClickCadastroCargos(object sender, RoutedEventArgs e)
        {
            new frmCargo().ShowDialog();
        }
        private void MnClickSair(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MnClickRegistrarPonto(object sender, RoutedEventArgs e)
        {
            new frmRegistroPonto().ShowDialog();
        }
    }
}