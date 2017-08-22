/***********************************************************************
 * Module:  ContratProvisoire.cs
 * Author:  CDI14
 * Purpose: Definition of the Class ContratProvisoire
 ***********************************************************************/

using System;

namespace ABICommercialProject
{
    public abstract class ContratProvisoire : Contrat
    {
        private String motif;
        private DateTime dateFinContrat;
        public ContratProvisoire(String motif, DateTime dateFinContrat, String qualification, DateTime dateDebutContrat, Statut statut, Decimal salaireBrut) : base(qualification, dateDebutContrat, statut, salaireBrut)
        {
            this.motif = motif;
            this.dateFinContrat = dateFinContrat;
        }

        protected String Motif
        {
            get
            {
                return motif;
            }
            set
            {
                if (this.motif != value)
                    this.motif = value;
            }
        }

        protected DateTime DateFinContrat
        {
            get
            {
                return dateFinContrat;
            }
            set
            {
                if (this.dateFinContrat != value)
                    this.dateFinContrat = value;
            }
        }

        public override String ToString()
        {
            return ("Contrat Provisoire");
        }


    }
}