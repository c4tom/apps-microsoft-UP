using RegistroPonto.Models;
using System.Collections.Generic;
using System.Linq;

namespace RegistroPonto.DAL
{
    class TipoEntradaSaidaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static bool Cadastrar(TipoEntradaSaida es)
        {
            ctx.EntradaSaidas.Add(es);
            ctx.SaveChanges();
            return true;
        }

        public static List<TipoEntradaSaida> Listar()
        {
            return ctx.EntradaSaidas.ToList();
        }
    }
}
