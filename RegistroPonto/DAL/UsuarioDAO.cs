using RegistroPonto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto.DAL
{
    class UsuarioDAO
    {
        private static Context ctx = new Context();

        public static bool Cadastrar(Usuario u)
        {
            return false;
        }

        public static Usuario BuscarPorNome(Usuario u)
        {
            return null;
        }

        public static List<Usuario> Listar ()
        {
            return null;
        }

        public static Usuario BuscaPorId(Usuario u)
        {
            return null;
        }
    }
}
