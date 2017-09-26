namespace ABIDAO
{
    using ABIModel;
    using EntityConfiguration;
    using System.Data.Entity;
    using System.Linq;

    public class ABIContext : DbContext
    {
        
        public ABIContext()
            : base("name=ABIModel")
        {
            //this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Collaborateur> Collaborateurs { get; set; }
        public virtual DbSet<Contrat> Contrats { get; set; }
        //public virtual DbSet<AugmentationSalaire> AugmentationSalaires { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CollaborateurConfiguration());
            modelBuilder.Configurations.Add(new ContratConfiguration());
            modelBuilder.Entity<ContratProvisoire>().Property(c => c.DateFinContrat).HasColumnType("datetime2");
            modelBuilder.Entity<AugmentationSalaire>().Property(a => a.Date).HasColumnType("datetime2");
            modelBuilder.Entity<Cdi>().Property(a => a.DateCloture).HasColumnType("datetime2");
        }
            
    }
}