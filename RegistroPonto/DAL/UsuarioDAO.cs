using RegistroPonto.Models;
using System.Collections.Generic;
using System.Linq;

namespace RegistroPonto.DAL
{
    class UsuarioDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static bool Cadastrar(Usuario u)
        {
            if (BuscarPorNome(u) == null)
            {
                ctx.Usuarios.Add(u);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static Usuario BuscarPorNome(Usuario u)
        {
            return ctx.Usuarios.FirstOrDefault(x => x.Nome.Equals(u.Nome));
        }

        public static Usuario BuscaPorRegistro(string registro)
        {
            return ctx.Usuarios.Include("Cargo").FirstOrDefault(x => x.Registro.Equals(registro));
        }

        public static List<Usuario> Listar()
        {
            return ctx.Usuarios.Include("Cargo").ToList();
        }

        public static Usuario BuscaPorId(int id)
        {
            return ctx.Usuarios.Include("Cargo").Where(x => x.UsuarioId == id).FirstOrDefault();
        }


        public static bool Atualizar(Usuario u)
        {
            ctx.Entry(u).State = System.Data.Entity.EntityState.Modified;
            var retorno = ctx.SaveChanges();
            if (retorno > 0)
            {
                return true;
            }
            return false;
        }
    }
}
