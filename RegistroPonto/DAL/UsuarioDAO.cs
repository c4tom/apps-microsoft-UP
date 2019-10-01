using RegistroPonto.Models;
using System.Collections.Generic;
using System.Linq;

namespace RegistroPonto.DAL
{
    class UsuarioDAO
    {
        private static Context ctx = new Context();

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
            return ctx.Usuarios.FirstOrDefault(x => x.Registro.Equals(registro));
        }

        public static List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }

        public static Usuario BuscaPorId(int id)
        {
            return ctx.Usuarios.Find(id);
        }
    }
}
