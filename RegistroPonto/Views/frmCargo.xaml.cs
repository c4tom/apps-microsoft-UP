using RegistroPonto.DAL;
using RegistroPonto.Models;
using System;
using System.Collections.Generic;
using System.Windows;


namespace RegistroPonto.Views
{
    /// <summary>
    /// Lógica interna para frmCargo.xaml
    /// </summary>
    public partial class frmCargo : Window
    {
        private List<dynamic> cargo = new List<dynamic>();
        public frmCargo()
        {
            InitializeComponent();
        }

        private void WindowOnLoad(object sender, RoutedEventArgs e)
        {
            MostrarDataGrid();
        }

        private void BtnNovo(object sender, RoutedEventArgs e)
        {
            LimparFormulario();
        }

        private void BtnSalvar(object sender, RoutedEventArgs e)
        {

            Cargo c = new Cargo
            {
                Nome = txtCargo.Text,
                Salario = Convert.ToDouble(txtSalario.Text)

            };

            if (CargoDAO.Cadastrar(c))
            {
                MessageBox.Show("Cadastrado!");
                LimparFormulario();
                MostrarDataGrid();
            };
        }

        private void MostrarDataGrid()
        {
            dtaCargo.ItemsSource = CargoDAO.Listar();
            dtaCargo.Items.Refresh();
        }

        private void LimparFormulario()
        {
            txtSalario.Clear();
            txtCargo.Clear();
            txtCargo.Focus();
        }
    }
}
