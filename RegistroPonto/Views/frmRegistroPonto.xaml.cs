using RegistroPonto.DAL;
using RegistroPonto.Models;
using RegistroPonto.Utils;
using System;
using System.Collections.Generic;
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
            cboEntradaSaida.ItemsSource = TipoEntradaSaidaDAO.Listar();
            cboEntradaSaida.DisplayMemberPath = "Tipo";
            cboEntradaSaida.SelectedValuePath = "TipoId";

            Title = Title + " - " + Uteis.UsuarioLogado.Nome;
            MostrarDataGrid();
        }
        public void CboxSelectionChange(object sender, SelectionChangedEventArgs e)
        {

        }
        private void BtnRegistrarPonto(object sender, RoutedEventArgs e)
        {
            // Adiciona registro ao banco de dados e mostra o valor no grid

            int TipoEntrada = Convert.ToInt32(cboEntradaSaida.SelectedValue);
            if (TipoEntrada == null)
            {
                MessageBox.Show("Favor, selecionar o tipo");
                return;
            }

            Ponto Ponto = new Ponto
            {
                Usuario = Uteis.UsuarioLogado,
                DataRegistro = DateTime.Now,
                Tipo = TipoEntradaSaidaDAO.BuscaPorId(TipoEntrada)
            };

            if (PontoDAO.Cadastrar(Ponto))
            {
                MostrarDataGrid();
                MessageBox.Show("Registro realizado com sucesso!", "Info", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Problema no registro!!");
            }
        }

        private void MostrarDataGrid()
        {
            List<dynamic> RegistrosPontos = new List<dynamic>();
            List<Ponto> Pontos = PontoDAO.Listar(Uteis.UsuarioLogado);
            foreach (Ponto rp in Pontos)
            {
                dynamic d = new
                {
                    DataRegistro = rp.DataRegistro.ToString("dd/MM/yyyy HH:mm:ss"),
                    Tipo = rp.Tipo.Tipo
                };
                RegistrosPontos.Add(d);
            }
            dtaDataHora.ItemsSource = RegistrosPontos;
            dtaDataHora.Items.Refresh();
        }
    }
}
