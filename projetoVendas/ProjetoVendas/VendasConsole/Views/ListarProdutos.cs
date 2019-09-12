using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarProdutos
    {
        public static void Renderizar()
        {
            Console.WriteLine("  -- LISTAR PRODUTOS --  \n");
            foreach (Produto produtoCadastrado in ProdutoDAO.ListarProdutos())
            {
                Console.WriteLine(produtoCadastrado);
            }
        }
    }
}
