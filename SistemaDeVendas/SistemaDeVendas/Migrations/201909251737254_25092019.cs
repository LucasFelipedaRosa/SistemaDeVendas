namespace SistemaDeVendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _25092019 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clientes", newName: "Pessoas");
            RenameColumn(table: "dbo.Pessoas", name: "Enderco_Id", newName: "Endereco_Id");
            RenameIndex(table: "dbo.Pessoas", name: "IX_Enderco_Id", newName: "IX_Endereco_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Pessoas", name: "IX_Endereco_Id", newName: "IX_Enderco_Id");
            RenameColumn(table: "dbo.Pessoas", name: "Endereco_Id", newName: "Enderco_Id");
            RenameTable(name: "dbo.Pessoas", newName: "Clientes");
        }
    }
}
