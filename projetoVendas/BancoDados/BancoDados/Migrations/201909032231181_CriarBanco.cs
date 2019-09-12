namespace BancoDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Quantidade = c.Int(nullable: false),
                        Preco = c.Double(nullable: false),
                        CriadoEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtos");
        }
    }
}
