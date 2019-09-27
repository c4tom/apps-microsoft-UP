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
using RegistroPonto.BancoDados;
using RegistroPonto.Modelo.Entidades;


namespace RegistroPonto.Views
{
    /// <summary>
    /// Lógica interna para frmCargo.xaml
    /// </summary>
    public partial class frmCargo : Window
    {
        public frmCargo()
        {
            InitializeComponent();
        }

        private void BtnNovo(object sender, RoutedEventArgs e)
        {
            txtCargo.Text = "";
            txtSalario.Text = "";
        }

        private void BtnSalvar(object sender, RoutedEventArgs e)
        {
            try
            {
                Cargo cargo = new Cargo();
                cargo.Nome = "adfafda";
                cargo.Salario = 500.44f;

                CargoBD cargobd = new CargoBD();
                cargobd.Criar(cargo);

                MessageBox.Show("ID" + cargo.Id.ToString());
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
