using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.DAL
{
    class CategoriaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static Categoria BuscarCategoriaPorNome
            (Categoria c) =>
            ctx.Categorias.FirstOrDefault
            (x => x.Nome.Equals(c.Nome));
    }
}
