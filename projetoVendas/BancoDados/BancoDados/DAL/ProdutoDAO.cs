using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.DAL
{
    class ProdutoDAO
    {
        //Any(): é método que retorna se existe 
        //algum registro na busca
        //Count(): é método que retorna a quantidade
        //itens dentro de uma busca
        // ctx.Vendas.Include("Cliente").Include("Vendedor").Include("Produtos.Produto.Categoria").ToList();

        private static Context ctx = SingletonContext.GetInstance();
        public static void CadastrarProduto(Produto p)
        {
            ctx.Produtos.Add(p);
            ctx.SaveChanges();
        }
        public static List<Produto> ListarProdutos() => ctx.Produtos.Include("Categoria").ToList();
        public static Produto BuscarProdutoPorNome(Produto p)
        {
            //FirstOrDefault: é o metodo que retorna o
            //PRIMEIRO objeto na busca
            return ctx.Produtos.FirstOrDefault
                (x => x.Nome.Equals(p.Nome));

            //SingleOrDefault: é o metodo que retorna um
            //ÚNICO objeto na busca
            //return ctx.Produtos.SingleOrDefault
            //    (x => x.Nome.Equals(p.Nome));
        }
        public static Produto BuscarProdutoPorData(DateTime data)
        {
            return ctx.Produtos.FirstOrDefault
                (x => x.CriadoEm.Day == data.Day &&
                    x.CriadoEm.Month == data.Month &&
                    x.CriadoEm.Year == data.Year);
        }
        public static List<Produto> BuscarProdutosPorParteNome(Produto p)
        {
            //Where: é método que retorna todas as
            //ocorrências em uma busca
            return ctx.Produtos.Where
                (x => x.Nome.Contains(p.Nome)).ToList();
        }
        public static double CalcularValorEstoque()
        {
            return ctx.Produtos.Sum
                (x => x.Quantidade * x.Preco);
        }
        public static void RemoverProduto(Produto p)
        {
            ctx.Produtos.Remove(p);
            ctx.SaveChanges();
        }
        public static void AlterarProduto(Produto p)
        {
            ctx.Entry(p).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
