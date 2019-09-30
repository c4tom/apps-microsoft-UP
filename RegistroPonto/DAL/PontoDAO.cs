using RegistroPonto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto.DAL
{
    class PontoDAO
    {
        private static Context ctx = new Context();

        public static bool Cadastrar(Ponto u)
        {
            return false;
        }

        public static Ponto BuscarPorNome(Ponto u)
        {
            return null;
        }

        public static List<Ponto> Listar()
        {
            return null;
        }

        public static Usuario BuscaPorId(Ponto u)
        {
            return null;
        }
    }
}
