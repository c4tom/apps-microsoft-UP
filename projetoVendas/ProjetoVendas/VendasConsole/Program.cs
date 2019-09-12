using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.ResetColor();
            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  -- PROJETO DE VENDAS CONSOLE --  \n");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nDigite a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("  -- CADASTRAR CLIENTE --  \n");
                        Cliente c = new Cliente();
                        Console.WriteLine("Digite o nome do cliente:");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente:");
                        c.Cpf = Console.ReadLine();
                        Console.WriteLine(c);
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                        break;
                    case 2:
                        Console.WriteLine("  -- LISTAR CLIENTE --  \n");

                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("\nAperte uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
