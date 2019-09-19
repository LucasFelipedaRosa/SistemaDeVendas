namespace SistemaDeVendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cricaodeentidadeseconeccaocomobanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeRazaoSocial = c.String(),
                        Cpf = c.String(),
                        DataDeNascimento = c.DateTime(),
                        Cnpj = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Enderco_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Enderecoes", t => t.Enderco_Id)
                .Index(t => t.Enderco_Id);
            
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cep = c.String(),
                        Rua = c.String(),
                        Numero = c.String(),
                        Cidade = c.String(),
                        Uf = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mercadorias",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Cadarso = c.Boolean(nullable: false),
                        Material = c.String(),
                        Cor = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Imagem = c.String(),
                        Grade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Grades", t => t.Grade_Id)
                .Index(t => t.Grade_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mercadorias", "Grade_Id", "dbo.Grades");
            DropForeignKey("dbo.Clientes", "Enderco_Id", "dbo.Enderecoes");
            DropIndex("dbo.Mercadorias", new[] { "Grade_Id" });
            DropIndex("dbo.Clientes", new[] { "Enderco_Id" });
            DropTable("dbo.Mercadorias");
            DropTable("dbo.Grades");
            DropTable("dbo.Enderecoes");
            DropTable("dbo.Clientes");
        }
    }
}
