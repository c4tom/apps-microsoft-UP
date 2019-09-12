using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarVendedores
    {
        public static void Renderizar()
        {
            Console.WriteLine("  -- LISTAR VENDEDORES --  \n");
            foreach (Vendedor vendedorCadastrado in VendedorDAO.ListarVendedores())
            {
                Console.WriteLine(vendedorCadastrado);
            }
        }
    }
}
