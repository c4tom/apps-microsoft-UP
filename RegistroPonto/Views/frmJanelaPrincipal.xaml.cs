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

        private void BtnClickRegistrarPonto(object sender, RoutedEventArgs e)
        {
            frmRegistroPonto frm = new frmRegistroPonto();
            frm.ShowDialog();
        }

        private void BtnClickCadastroUsuario(object sender, RoutedEventArgs e)
        {
            frmCadastroUsuario frm = new frmCadastroUsuario();
            frm.ShowDialog();
        }
    }
}
