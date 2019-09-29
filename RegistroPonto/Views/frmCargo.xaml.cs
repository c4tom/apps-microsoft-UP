using System;
using System.Windows;


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

        }

        private void BtnSalvar(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
