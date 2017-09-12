using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABICommercialProject.DAO.EntityConfiguration
{
    public class ContratConfiguration : EntityTypeConfiguration<Contrat>
    {
        public ContratConfiguration()
        {
            HasRequired(c => c.Collaborateur)
                .WithMany(c => c.Contrats)
                .HasForeignKey(c => c.CollaborateurID)
                .WillCascadeOnDelete(false);
        }
    }
}
