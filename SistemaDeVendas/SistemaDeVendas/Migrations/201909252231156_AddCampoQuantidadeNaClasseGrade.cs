namespace SistemaDeVendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCampoQuantidadeNaClasseGrade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Grades", "Tamanho", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Grades", "Tamanho");
        }
    }
}
