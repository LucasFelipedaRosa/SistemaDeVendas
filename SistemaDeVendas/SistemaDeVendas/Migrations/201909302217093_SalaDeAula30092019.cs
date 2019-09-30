namespace SistemaDeVendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalaDeAula30092019 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mercadorias", "Modelo", c => c.String());
            DropColumn("dbo.Grades", "Tamanho");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Grades", "Tamanho", c => c.String());
            DropColumn("dbo.Mercadorias", "Modelo");
        }
    }
}
