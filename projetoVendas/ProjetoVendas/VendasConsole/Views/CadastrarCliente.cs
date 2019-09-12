using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views
{
    class CadastrarCliente
    {
        //https://www.geradorcpf.com/algoritmo_do_cpf.htm
        public static void Renderizar()
        {
            Cliente c = new Cliente();
            Console.WriteLine("  -- CADASTRAR CLIENTE --  \n");
            Console.WriteLine("Digite o nome do cliente:");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente:");
            c.Cpf = Console.ReadLine();
            if (Validacao.ValidarCpf(c.Cpf))
            {
                if (ClienteDAO.CadastrarCliente(c))
                {
                    Console.WriteLine("Cliente cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Cliente já cadastrado!");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }

        }
    }
}
