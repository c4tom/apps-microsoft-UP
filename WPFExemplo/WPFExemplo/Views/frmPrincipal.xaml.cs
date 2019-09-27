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

namespace WPFExemplo.Views
{
    /// <summary>
    /// Interaction logic for frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSomar_Click(object sender, RoutedEventArgs e)
        {
            if (!txtNumero1.Text.Equals("") &&
                !txtNumero2.Text.Equals(""))
            {
                double n1 = Convert.ToDouble(txtNumero1.Text);
                double n2 = Convert.ToDouble(txtNumero2.Text);
                double soma = n1 + n2;
                MessageBox.Show("O resultado é: " + soma,
                    "WPF Exemplo", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                lblResultado.Content = "Resultado: " + soma;

                txtNumero1.Clear();
                txtNumero2.Text = "";
                txtNumero1.Focus();
            }
            else
            {
                MessageBox.Show("Favor preencher os campos!",
                    "WPF Exemplo", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void BtnAbrirJanela_Click(object sender, RoutedEventArgs e)
        {
            frmTeste form = new frmTeste();
            //form.Show();
            form.ShowDialog();
        }
    }
}
