/***********************************************************************
 * Module:  ContratProvisoire.cs
 * Author:  CDI14
 * Purpose: Definition of the Class ContratProvisoire
 ***********************************************************************/

using System;

namespace ABICommercialProject.Model
{
    public abstract class ContratProvisoire : Contrat
    {
        private String motif;
        private DateTime dateFinContrat;

        public ContratProvisoire()
        {

        }
        /// <summary>
        /// Constructor to instanciate a temporary contract
        /// </summary>
        /// <param name="motif"></param>
        /// <param name="dateFinContrat"></param>
        /// <param name="qualification"></param>
        /// <param name="dateDebutContrat"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        public ContratProvisoire(String motif, DateTime dateFinContrat, String qualification, DateTime dateDebutContrat, Statut statut, Decimal salaireBrut) : base(qualification, dateDebutContrat, statut, salaireBrut)
        {
            Motif = motif;
            DateFinContrat = dateFinContrat;
            
        }

        public String Motif
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

        /// <summary>
        /// 
        /// </summary>
        public DateTime DateFinContrat
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

        /// <summary>
        /// Return the temporary contract 
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return  base.ToString() 
                + "\nMotif : " + motif 
                + "\nDate Fin Contrat : " + dateFinContrat;
        }


    }
}