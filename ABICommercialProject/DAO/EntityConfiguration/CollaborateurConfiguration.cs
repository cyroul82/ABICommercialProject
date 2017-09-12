using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABICommercialProject.DAO.EntityConfiguration
{
    public class CollaborateurConfiguration : EntityTypeConfiguration<Collaborateur>
    {
        public CollaborateurConfiguration()
        {
            Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(50);

            Property(t => t.Firstname)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}
