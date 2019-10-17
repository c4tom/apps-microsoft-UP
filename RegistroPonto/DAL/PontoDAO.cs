using RegistroPonto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return ctx.Pontos.Where(p => DbFunctions.TruncateTime(p.DataRegistroEntrada) == DbFunctions.TruncateTime(dt)).ToList();
        }

        public static Ponto BuscaUltimoRegistro(Usuario u)
        {
            return ctx.Pontos.Where(x => x.Usuario.UsuarioId == u.UsuarioId).Take(1).FirstOrDefault();
        }

        public static void Remove(Ponto p)
        {
            ctx.Pontos.Remove(p);
            ctx.SaveChanges();
        }

        public static void Alterar(Ponto p)
        {
            ctx.Entry(p).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        // Listar por usuário 
        public static List<Ponto> Listar(Usuario u)
        {
            return ctx.Pontos
                .Include("Usuario")
                .Where(x => x.Usuario.UsuarioId == u.UsuarioId).OrderByDescending(x => x.DataRegistroEntrada).ToList();
        }


        public static List<Ponto> ListarSomatorioPorUsuarioEDia(Usuario u)
        {
            return ctx.Pontos
                .Include("Usuario")
                .Where(x => x.Usuario.UsuarioId == u.UsuarioId).OrderByDescending(x => x.DataRegistroEntrada).ToList();
        }
    }
}
