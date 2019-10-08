namespace SistemaDeVendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GradeTamanho : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Grades", "Tamanho");
            AddColumn("dbo.Grades", "Tamanho", c => c.String());
        }

        public override void Down()
        {
        }
    }
}
