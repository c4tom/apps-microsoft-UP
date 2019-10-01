using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroPonto.Models;

namespace RegistroPonto.Migrations
{
    class PopulateInicio
    {
        public static void Popular(Context context)
        {
            TipoEntradaSaida e1 = new TipoEntradaSaida(1, "Entrada");
            TipoEntradaSaida e2 = new TipoEntradaSaida(1, "Saída");

            context.EntradaSaidas.Add(e1);
            context.EntradaSaidas.Add(e2);

            Cargo c1, c2, c3;
            c1 = new Cargo(1, "Secretária", 1500f);
            c2 = new Cargo(2, "Motorista", 1230.33f);
            c3 = new Cargo(3, "Analista", 3600.50f);

            context.Cargos.Add(c1);
            context.Cargos.Add(c2);
            context.Cargos.Add(c3);

            Usuario u1 = new Usuario(1, "Euzinho Adm", "00001", DateTime.Now, c3);
            Usuario u2 = new Usuario(1, "Ana Paula Silva", "00002", DateTime.Now, c1);

            context.Usuarios.Add(u1);
            context.Usuarios.Add(u2);
        }
    }
}
