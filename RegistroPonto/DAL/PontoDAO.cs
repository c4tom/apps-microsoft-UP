using RegistroPonto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RegistroPonto.DAL
{
    class PontoDAO
    {
        private static Context ctx = new Context();

        public static bool Cadastrar(Ponto p)
        {
            ctx.Pontos.Add(p);
            ctx.SaveChanges();
            return true;
        }

        public static List<Ponto> BuscarPorData(DateTime dt)
        {
            return ctx.Pontos.Where(p => DbFunctions.TruncateTime(p.DataRegistro) == DbFunctions.TruncateTime(dt)).ToList();
        }

        public static List<Ponto> Listar()
        {
            return ctx.Pontos.ToList();
        }
    }
}
