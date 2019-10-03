namespace SistemaDeVendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Casa02102019 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mercadorias", "Modelo", c => c.String());
        }

        public override void Down()
        {
        }
    }
}
