namespace SistemaDeVendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class opaa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Mercadorias", "Grade_Id", "dbo.Grades");
            DropIndex("dbo.Mercadorias", new[] { "Grade_Id" });
            AddColumn("dbo.Grades", "Mercadoria_Id", c => c.Int());
            CreateIndex("dbo.Grades", "Mercadoria_Id");
            AddForeignKey("dbo.Grades", "Mercadoria_Id", "dbo.Mercadorias", "Id");
            DropColumn("dbo.Mercadorias", "Grade_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Mercadorias", "Grade_Id", c => c.Int());
            DropForeignKey("dbo.Grades", "Mercadoria_Id", "dbo.Mercadorias");
            DropIndex("dbo.Grades", new[] { "Mercadoria_Id" });
            DropColumn("dbo.Grades", "Mercadoria_Id");
            CreateIndex("dbo.Mercadorias", "Grade_Id");
            AddForeignKey("dbo.Mercadorias", "Grade_Id", "dbo.Grades", "Id");
        }
    }
}
