using RegistroPonto.DAL;
using System.Windows;
using System.Windows.Controls;

namespace RegistroPonto.Views
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

        public void WindowOnLoad(object sender, RoutedEventArgs e)
        {
            cbEntradaSaida.ItemsSource = TipoEntradaSaidaDAO.Listar();
            cbEntradaSaida.DisplayMemberPath = "Tipo";
            cbEntradaSaida.SelectedValuePath = "TipoId";
        }
        public void CboxSelectionChange(object sender, SelectionChangedEventArgs e)
        {

        }
        private void BtnRegistrarPonto(object sender, RoutedEventArgs e)
        {
            // Adiciona registro ao banco de dados e mostra o valor no grid

            MessageBox.Show("Registro realizado com sucesso!", "Info", MessageBoxButton.OK);
        }

        private void MostrarDataGrid()
        {
            dtaDataHora.ItemsSource = TipoEntradaSaidaDAO.Listar();
            dtaDataHora.Items.Refresh();
        }
    }
}
