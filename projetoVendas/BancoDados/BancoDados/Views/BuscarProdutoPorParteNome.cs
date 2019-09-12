using BancoDados.DAL;
using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Views
{
    class BuscarProdutoPorParteNome
    {
        public static void Renderizar()
        {
            Produto p = new Produto();
            Console.WriteLine("  -- BUSCAR PRODUTOS POR PARTE DO NOME --  \n");
            Console.WriteLine("Digite o nome do produto:");
            p.Nome = Console.ReadLine();
            foreach (Produto item in 
                ProdutoDAO.BuscarProdutosPorParteNome(p))
            {
                Console.WriteLine(item);
            }
        }
    }
}
