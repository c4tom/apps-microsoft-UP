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

            PopulateInicio.Popular(context);
        }
    }
}
