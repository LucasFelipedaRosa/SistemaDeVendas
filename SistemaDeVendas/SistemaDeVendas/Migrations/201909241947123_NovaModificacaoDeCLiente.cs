namespace SistemaDeVendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovaModificacaoDeCLiente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Clientes", "DataDeNascimento", c => c.DateTime());
            DropColumn("dbo.Clientes", "PF");
            DropColumn("dbo.Clientes", "RazaoSocial");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "RazaoSocial", c => c.String());
            AddColumn("dbo.Clientes", "PF", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Clientes", "DataDeNascimento", c => c.DateTime(nullable: false));
            DropColumn("dbo.Clientes", "Discriminator");
        }
    }
}
