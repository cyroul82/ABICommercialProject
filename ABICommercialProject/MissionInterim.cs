/***********************************************************************
 * Module:  MissionInterim.cs
 * Author:  CDI14
 * Purpose: Definition of the Class MissionInterim
 ***********************************************************************/

using System;

namespace ABICommercialProject
{
    public class MissionInterim : ContratProvisoire
    {
        private String agenceInterim;

        public MissionInterim(String agenceInterim, String motif, DateTime dateFinContrat, String qualification, DateTime dateDebutContrat, Statut statut, Decimal salaireBrut) : base(motif, dateFinContrat, qualification, dateDebutContrat, statut, salaireBrut)
        {
            this.agenceInterim = agenceInterim;
        }


        public String AgenceInterim
        {
            get
            {
                return agenceInterim;
            }
            set
            {
                if (this.agenceInterim != value)
                    this.agenceInterim = value;
            }
        }

        public override String ToString()
        {
            return null;
        }

    }
}