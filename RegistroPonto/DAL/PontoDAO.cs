using RegistroPonto.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RegistroPonto.DAL
{
    class PontoDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

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


        // Listar por usuário 
        public static List<Ponto> Listar(Usuario u)
        {
            return ctx.Pontos
                .Include("Tipo")
                .Include("Usuario")
                .Where(x => x.Usuario.UsuarioId == u.UsuarioId).OrderBy(x => x.DataRegistro).ToList();
        }
    }
}
