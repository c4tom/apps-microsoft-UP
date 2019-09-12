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
    class CadastrarVenda
    {
        public static void Renderizar()
        {
            Venda venda = new Venda();
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
            Produto p = new Produto();
            Console.WriteLine("  -- CADASTRAR VENDA --  \n");
            Console.WriteLine("Digite o CPF do cliente:");
            c.Cpf = Console.ReadLine();
            c = ClienteDAO.BuscarClientePorCpf(c);
            if(c != null)
            {
                venda.Cliente = c;
                Console.WriteLine("Digite o CPF do vendedor:");
                v.Cpf = Console.ReadLine();
                v = VendedorDAO.BuscarVendedorPorCpf(v);
                if(v != null)
                {
                    venda.Vendedor = v;


                    Console.WriteLine("Digite o nome do produto:");
                    p.Nome = Console.ReadLine();
                    if(p != null)
                    {
                        venda.Produto = p;
                        Console.WriteLine("Digite a quantidade do produto:");
                        venda.Quantidade = Convert.ToInt32(Console.ReadLine());
                        VendaDAO.CadastrarVenda(venda);
                        Console.WriteLine("Venda cadastrada!");
                    }
                    else
                    {
                        Console.WriteLine("Esse produto não existe!");
                    }
                }
                else
                {
                    Console.WriteLine("Esse vendedor não existe!");
                }
                //Vendedor e Produto
            }
            else
            {
                Console.WriteLine("Esse cliente não existe!");
            }
        }
    }
}
