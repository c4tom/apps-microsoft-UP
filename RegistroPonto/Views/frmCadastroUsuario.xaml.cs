using RegistroPonto.DAL;
using RegistroPonto.Models;
using System.Collections.Generic;
using System.Windows;

namespace RegistroPonto.Views
{
    /// <summary>
    /// Lógica interna para frmCadastroUsuario.xaml
    /// </summary>
    public partial class frmCadastroUsuario : Window
    {
        private List<dynamic> usuarios = new List<dynamic>();
        public frmCadastroUsuario()
        {
            InitializeComponent();

        }

        private void WindowOnLoad(object sender, RoutedEventArgs e)
        {
            MostrarDataGrid();
            cboCargo.ItemsSource = CargoDAO.Listar();
            cboCargo.DisplayMemberPath = "Nome";
            cboCargo.SelectedValuePath = "CargoId";
        }

        private void BtnCadastrarUsuario(object sender, RoutedEventArgs e)
        {
            Usuario u = new Usuario
            {
                Nome = txtNome.Text,
                Registro = txtRegistro.Text,
                DataNascimento = System.DateTime.Parse(txtDataNascimento.Text),
                Cargo = new Cargo
                {
                    CargoId = cboCargo.SelectedIndex
                }
            };
            if (UsuarioDAO.Cadastrar(u))
            {
                MessageBox.Show("Registro realizado com sucesso!", "Info", MessageBoxButton.OK);
                LimparFormulario();
                MostrarDataGrid();
            }
            else
            {
                MessageBox.Show("Já existe!");
            }

        }

        private void BtnClickNovoRegistro(object sender, RoutedEventArgs e)
        {
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            txtDataNascimento.Text = "";
            txtNome.Clear();
            txtRegistro.Clear();
        }

        private void MostrarDataGrid()
        {
            dtaUsuarios.ItemsSource = UsuarioDAO.Listar();
            dtaUsuarios.Items.Refresh();
        }
    }
}
