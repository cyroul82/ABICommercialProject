/***********************************************************************
 * Module:  Stage.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Stage
 ***********************************************************************/

using System;

namespace ABICommercialProject
{
    public class Stage : ContratProvisoire
    {
        public Stage(String ecole, String mission, String motif, DateTime dateFinContrat, String qualification, DateTime dateDebutContrat, Statut statut, Decimal salaireBrut) : base(motif, dateFinContrat, qualification, dateDebutContrat, statut, salaireBrut)
        {
            this.ecole = ecole;
            this.mission = mission;
        }

        public override String ToString()
        {
            // TODO: implement
            return null;
        }

        private String ecole;
        private String mission;

        public String Ecole
        {
            get
            {
                return ecole;
            }
            set
            {
                if (this.ecole != value)
                    this.ecole = value;
            }
        }

        public String Mission
        {
            get
            {
                return mission;
            }
            set
            {
                if (this.mission != value)
                    this.mission = value;
            }
        }

    }
}