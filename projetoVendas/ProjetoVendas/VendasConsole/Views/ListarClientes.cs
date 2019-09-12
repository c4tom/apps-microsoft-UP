using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarClientes
    {
        public static void Renderizar()
        {
            Console.WriteLine("  -- LISTAR CLIENTE --  \n");
            foreach (Cliente clienteCadastrado in ClienteDAO.ListarClientes())
            {
                Console.WriteLine(clienteCadastrado);
            }
        }
    }
}
