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
        static DateTime? dIn, dOut = null;
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
            if (TipoEntrada == 0)
            {
                MessageBox.Show("Favor, selecionar o tipo");
                return;
            }

            Ponto UltimoRegistro = PontoDAO.BuscaUltimoRegistro(Uteis.UsuarioLogado);

            if(UltimoRegistro == null && UltimoRegistro.DataRegistroSaida == null)
            {
                // Deve registrar a entrada, pois o ultimo registro, mesmo não tendo nenhum
                if(TipoEntrada == 2)
                {
                    MessageBox.Show("Favor, você deve registrar a entrada");
                }
            }

            if (TipoEntrada == 1)
            {
                dIn = DateTime.Now;
            }
            else
            {
                dOut = DateTime.Now;
            }
            
            Ponto Ponto = new Ponto
            {
                Usuario = Uteis.UsuarioLogado,
                DataRegistroEntrada = dIn,
                DataRegistroSaida = dOut
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
            //foreach (Ponto rp in Pontos)
            //{
            //    dynamic d = new
            //    {
            //        PontoId = rp.PontoId,
            //        DataRegistroEntrada = rp.DataRegistroEntrada?.ToString("dd/MM/yyyy HH:mm:ss"),
            //        DataRegistroSaida = rp.DataRegistroSaida?.ToString("dd/MM/yyyy HH:mm:ss"),
            //        Usuario = rp.Usuario
            //    };
            //    RegistrosPontos.Add(d);
            //}
            dtaDataHora.ItemsSource = Pontos;
            dtaDataHora.Items.Refresh();
        }

        private void DTAChange(object sender, SelectionChangedEventArgs e)
        {
            dynamic p = dtaDataHora.SelectedItem;
            PontoDAO.Remove(p);
            MostrarDataGrid();
        }
    }
}
