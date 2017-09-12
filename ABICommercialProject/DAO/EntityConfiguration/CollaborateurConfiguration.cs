using ABICommercialProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
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
            .HasMaxLength(50)
            .HasColumnAnnotation("Index", 
                                    new IndexAnnotation(
                                        new IndexAttribute("IX_NameFirstname", 1) { IsUnique = true })
                                                        );
            

            Property(t => t.Firstname)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnAnnotation("Index",
                                    new IndexAnnotation(
                                        new IndexAttribute("IX_NameFirstname", 2) { IsUnique = true })
                                                        );

        }
    }
}
