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

namespace Registro_de_Ponto.Views
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
