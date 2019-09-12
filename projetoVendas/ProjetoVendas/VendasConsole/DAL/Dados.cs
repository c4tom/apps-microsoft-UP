using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class Dados
    {
        public static void Inicializar()
        {
            Cliente c = new Cliente
            {
                Nome = "Diogo Deconto",
                Cpf = "05363419904",
                CriadoEm = DateTime.Now
            };
            Vendedor v = new Vendedor
            {
                Nome = "José da Silva",
                Cpf = "05363419904",
                CriadoEm = DateTime.Now
            };
            Produto p = new Produto
            {
                Nome = "Bolacha",
                Quantidade = 100,
                Preco = 3.5,
                CriadoEm = DateTime.Now
            };
            ClienteDAO.CadastrarCliente(c);
            VendedorDAO.CadastrarVendedor(v);
            ProdutoDAO.CadastrarProduto(p);
        }
    }
}
