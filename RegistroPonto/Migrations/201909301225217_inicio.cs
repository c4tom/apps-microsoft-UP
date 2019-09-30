namespace RegistroPonto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cargo",
                c => new
                    {
                        CargoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Salario = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CargoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cargo");
        }
    }
}
