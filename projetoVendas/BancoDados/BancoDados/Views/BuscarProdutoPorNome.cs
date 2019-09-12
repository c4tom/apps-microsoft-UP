using BancoDados.DAL;
using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Views
{
    class BuscarProdutoPorNome
    {
        public static void Renderizar()
        {
            Produto p = new Produto();
            Console.WriteLine("  -- BUSCAR PRODUTO --  \n");
            Console.WriteLine("Digite o nome do produto:");
            p.Nome = Console.ReadLine();
            p = ProdutoDAO.BuscarProdutoPorNome(p);
            if(p != null)
            {
                Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine("Esse produto não existe");
            }

        }
    }
}
