namespace SistemaDeVendas
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelVendas : DbContext
    {
        // Your context has been configured to use a 'ModelVendas' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SistemaDeVendas.ModelVendas' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelVendas' 
        // connection string in the application configuration file.
        public ModelVendas()
            : base("name=ModelVendas")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Mercadoria> Mercadorias { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<ClientePf> ClientePf { get; set; }
        public virtual DbSet<ClientePj> ClientePj { get; set; }
    }

  
}