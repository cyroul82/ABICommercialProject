/***********************************************************************
 * Module:  Stage.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Stage
 ***********************************************************************/

using System;

namespace ABICommercialProject.Model
{
    public class Stage : ContratProvisoire
    {
        public Stage()
        {
                
        }
        /// <summary>
        /// Constructor to instanciate a stage
        /// </summary>
        /// <param name="ecole"></param>
        /// <param name="mission"></param>
        /// <param name="motif"></param>
        /// <param name="dateFinContrat"></param>
        /// <param name="qualification"></param>
        /// <param name="dateDebutContrat"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        public Stage(String ecole, String mission, String motif, DateTime dateFinContrat, String qualification, DateTime dateDebutContrat, Statut statut, Decimal salaireBrut) : base(motif, dateFinContrat, qualification, dateDebutContrat, statut, salaireBrut)
        {
            Ecole = ecole;
            Mission = mission;
        }

        public override String ToString()
        {
            return "Contrat Provisoire : " + base.ToString() 
                                           + "\nEcole : " + ecole 
                                           + "\nMission : " + mission;

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