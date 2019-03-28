namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Endereco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        UF_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UFs", t => t.UF_ID)
                .Index(t => t.UF_ID);
            
            CreateTable(
                "dbo.UFs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sigla = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.CLIENTE", "Logradouro", c => c.String());
            AddColumn("dbo.CLIENTE", "Numero", c => c.String());
            AddColumn("dbo.CLIENTE", "CEP", c => c.String());
            AddColumn("dbo.CLIENTE", "Cidade_ID", c => c.Int());
            AddColumn("dbo.CLIENTE", "UF_ID", c => c.Int());
            CreateIndex("dbo.CLIENTE", "Cidade_ID");
            CreateIndex("dbo.CLIENTE", "UF_ID");
            AddForeignKey("dbo.CLIENTE", "Cidade_ID", "dbo.Cidades", "ID");
            AddForeignKey("dbo.CLIENTE", "UF_ID", "dbo.UFs", "ID");
            DropColumn("dbo.CLIENTE", "Endereco");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CLIENTE", "Endereco", c => c.String());
            DropForeignKey("dbo.CLIENTE", "UF_ID", "dbo.UFs");
            DropForeignKey("dbo.CLIENTE", "Cidade_ID", "dbo.Cidades");
            DropForeignKey("dbo.Cidades", "UF_ID", "dbo.UFs");
            DropIndex("dbo.CLIENTE", new[] { "UF_ID" });
            DropIndex("dbo.CLIENTE", new[] { "Cidade_ID" });
            DropIndex("dbo.Cidades", new[] { "UF_ID" });
            DropColumn("dbo.CLIENTE", "UF_ID");
            DropColumn("dbo.CLIENTE", "Cidade_ID");
            DropColumn("dbo.CLIENTE", "CEP");
            DropColumn("dbo.CLIENTE", "Numero");
            DropColumn("dbo.CLIENTE", "Logradouro");
            DropTable("dbo.UFs");
            DropTable("dbo.Cidades");
        }
    }
}
