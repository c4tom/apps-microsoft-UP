using RegistroPonto.Models;
using System;

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

            Cargo c1, c2, c3, c4;
            c1 = new Cargo(1, "Secretária", 1500f);
            c2 = new Cargo(2, "Motorista", 1230.33f);
            c3 = new Cargo(3, "Analista", 3600.50f);
            c4 = new Cargo(4, "Contador", 3010.50f);

            context.Cargos.Add(c1);
            context.Cargos.Add(c2);
            context.Cargos.Add(c3);
            context.Cargos.Add(c4);

            Usuario u1 = new Usuario(1, "Euzinho ", "Adm", "00001", DateTime.Now, c3);
            Usuario u2 = new Usuario(2, "Ana Paula ", "Silva", "00002", DateTime.Now, c1);
            Usuario u3 = new Usuario(3, "Geane ", "Sales", "00003", DateTime.Now, c2);
            Usuario u4 = new Usuario(4, "Antonio Carlos ", "Ribas", "00004", DateTime.Now, c2);

            context.Usuarios.Add(u1);
            context.Usuarios.Add(u2);
            context.Usuarios.Add(u3);
            context.Usuarios.Add(u4);

 

            // Popular Registros de Pontos
            Random rand = new Random();
            // Gerar registros de ponto
            for (int i = 0; i < 1000; i++)
            {
                rand.Next();
                int range = 2 * 365; //5 years          
                DateTime entrada = createRandomDate(rand, range);
                DateTime saida = entrada.AddMinutes(GetRandomNumber(rand, 60, 350));
                Console.WriteLine(entrada + " - " + saida);

                int r = rand.Next(1, 4);
               
                context.Pontos.Add( new Ponto(entrada, saida, context.Usuarios.Find(r)));
            }
        }

        public static DateTime createRandomDate(Random gen, int range)
        {
            DateTime randomDate = DateTime.Today.AddDays(-gen.Next(range)).AddHours(gen.Next(6,18));
            return randomDate;
        }

        public static double GetRandomNumber(Random random, double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
