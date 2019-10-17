using RegistroPonto.DAL;
using RegistroPonto.Models;
using System;
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

        Usuario edit = new Usuario();

        private static bool editando = false;
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

            if (editando)
            {
                edit.UsuarioId = Convert.ToInt32(txtID.Text);
                edit.Nome = txtNome.Text;
                edit.Sobrenome = txtSobrenome.Text;
                edit.Registro = txtRegistro.Text;
                edit.DataNascimento = System.DateTime.Parse(txtDataNascimento.Text);
                edit.Cargo = CargoDAO.BuscaPorId(((Cargo)cboCargo.SelectedItem).CargoId);
                
                if(UsuarioDAO.Atualizar(edit))
                {
                    MessageBox.Show("Registro atualizado com sucesso!", "Info", MessageBoxButton.OK);
                } else
                {
                    MessageBox.Show("Não foi atualizado!");
                }

                editando = false;
                LimparFormulario();

                MostrarDataGrid();
            }
            else
            {

                Usuario u = new Usuario
                {
                    Nome = txtNome.Text,
                    Sobrenome = txtSobrenome.Text,
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
            txtSobrenome.Clear();
        }

        private void MostrarDataGrid()
        {
            dtaUsuarios.ItemsSource = UsuarioDAO.Listar();
            dtaUsuarios.Items.Refresh();
        }

        private void DtaUsuarios_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            edit = (Usuario)dtaUsuarios.SelectedItem;

            editando = true;

            txtID.Text = edit.UsuarioId.ToString();
            txtRegistro.Text = edit.Registro;
            txtNome.Text = edit.Nome;
            cboCargo.SelectedItem = edit.Cargo;
            txtDataNascimento.SelectedDate = edit.DataNascimento;
            txtSobrenome.Text = edit.Sobrenome;

            //btnSalvar.Visibility = Visibility.Hidden;
        }

        private void BtnNovo(object sender, RoutedEventArgs e)
        {
            editando = false;
            LimparFormulario();
            edit = new Usuario();
        }
    }
}
