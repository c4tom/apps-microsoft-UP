using RegistroPonto.DAL;
using RegistroPonto.Models;
using System.Windows;
namespace RegistroPonto.Views
{
    /// <summary>
    /// Lógica interna para frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        private Usuario usuario { get; set; } = new Usuario();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnClickLogin(object sender, RoutedEventArgs e)
        {
            if (txtRegistro != null)
            {
                Usuario u =  UsuarioDAO.BuscaPorRegistro(txtRegistro.Text);


                frmJanelaPrincipal main = new frmJanelaPrincipal();
                main.Show();
                //main.Title = main.Title + " - " + u.Nome;
                this.Close();
            }

        }

    }
}
