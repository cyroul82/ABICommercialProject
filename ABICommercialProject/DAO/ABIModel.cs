namespace ABICommercialProject.DAO
{
    using EntityConfiguration;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ABIModel : DbContext
    {
        // Your context has been configured to use a 'ABIModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ABICommercialProject.DAO.ABIModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ABIModel' 
        // connection string in the application configuration file.
        public ABIModel()
            : base("name=ABIModel")
        {
        }

        public virtual DbSet<Collaborateur> Collaborateurs { get; set; }
        public virtual DbSet<Contrat> Contrats { get; set; }
        public virtual DbSet<AugmentationSalaire> AugmentationSalaires { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CollaborateurConfiguration());
            modelBuilder.Configurations.Add(new ContratConfiguration());
        }
            
    }
}