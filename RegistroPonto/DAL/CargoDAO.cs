using RegistroPonto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto.DAL
{
    class CargoDAO
    {
        private static Context ctx = new Context();

        public static bool Cadastrar(Cargo u)
        {
            return false;
        }

        public static Cargo BuscarPorNome(Cargo u)
        {
            return null;
        }

        public static List<Cargo> Listar()
        {
            return null;
        }

        public static Cargo BuscaPorId(Cargo u)
        {
            return null;
        }
    }
}
