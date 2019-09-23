namespace SistemaDeVendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificacaoNaClasseCLiente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "PF", c => c.Boolean(nullable: false));
            AddColumn("dbo.Clientes", "Nome", c => c.String());
            AddColumn("dbo.Clientes", "RazaoSocial", c => c.String());
            AlterColumn("dbo.Clientes", "DataDeNascimento", c => c.DateTime(nullable: false));
            DropColumn("dbo.Clientes", "NomeRazaoSocial");
            DropColumn("dbo.Clientes", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Clientes", "NomeRazaoSocial", c => c.String());
            AlterColumn("dbo.Clientes", "DataDeNascimento", c => c.DateTime());
            DropColumn("dbo.Clientes", "RazaoSocial");
            DropColumn("dbo.Clientes", "Nome");
            DropColumn("dbo.Clientes", "PF");
        }
    }
}
