using ABIModel;
using System.Data.Entity.ModelConfiguration;

namespace ABIDAO.EntityConfiguration
{
    public class ContratConfiguration : EntityTypeConfiguration<Contrat>
    {
        public ContratConfiguration()
        {
            Property(c => c.DateDebutContrat)
                .HasColumnType("datetime2");

            Property(c => c.DateFinEffectif)
                .HasColumnType("datetime2");

            Property(c => c.Qualification)
                .HasMaxLength(200);

            Property(c => c.MotifCloture)
                .HasMaxLength(2000);

            //HasRequired(c => c.Collaborateur)
            //    .WithMany(c => c.Contrats)
            //    .HasForeignKey(c => c.CollaborateurID)
            //    .WillCascadeOnDelete(false);

            //HasRequired(c => c.Collaborateur)
            //    .WithMany(c => c.Contrats)
            //    .WillCascadeOnDelete(false);



        }
    }
}
