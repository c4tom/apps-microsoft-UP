using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Models
{
    class Context : DbContext
    {
        //Nomear o arquivo do banco de dados
        public Context() : base("DbProdutos") { }

        //Definir as classes que vão tabelas no banco
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

    }
}
