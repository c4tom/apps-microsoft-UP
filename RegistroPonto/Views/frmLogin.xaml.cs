using RegistroPonto.DAL;
using RegistroPonto.Models;
using RegistroPonto.Utils;
using System.Windows;
namespace RegistroPonto.Views
{
    /// <summary>
    /// Lógica interna para frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnClickLogin(object sender, RoutedEventArgs e)
        {
            if (txtRegistro != null)
            {
                Usuario u = UsuarioDAO.BuscaPorRegistro(txtRegistro.Text);
                if (u == null)
                {
                    MessageBox.Show("Registro e/ou senha inválido.!!!");
                    return;
                }

                // Salva na "sessao"
                Uteis.UsuarioLogado = u;

                frmJanelaPrincipal main = new frmJanelaPrincipal();
                main.Show();
                main.Title = main.Title + " - " + u.Nome;
                this.Close();
            }

        }

    }
}
