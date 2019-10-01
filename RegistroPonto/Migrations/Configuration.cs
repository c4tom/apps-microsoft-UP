namespace RegistroPonto.Migrations
{
    using RegistroPonto.Models;
    using System;
    using System.Data.Entity.Migrations;
    internal sealed class Configuration : DbMigrationsConfiguration<RegistroPonto.Models.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RegistroPonto.Models.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

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

            Usuario u1 = new Usuario(1, "Euzinho Adm", "00001", DateTime.Now, context.Cargos.Find(1));
            Usuario u2 = new Usuario(1, "Ana Paula Silva", "49002", DateTime.Now, context.Cargos.Find(2));

            context.Usuarios.Add(u1);
            context.Usuarios.Add(u2);
        }
    }
}
