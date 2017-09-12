/***********************************************************************
 * Module:  MissionInterim.cs
 * Author:  CDI14
 * Purpose: Definition of the Class MissionInterim
 ***********************************************************************/

using ABICommercialProject.Model;
using System;

namespace ABICommercialProject.Model
{
    public class MissionInterim : ContratProvisoire
    {
        private String agenceInterim;

        /// <summary>
        /// Constructor to instanciate a MissionInterim
        /// </summary>
        /// <param name="agenceInterim"></param>
        /// <param name="motif"></param>
        /// <param name="dateFinContrat"></param>
        /// <param name="qualification"></param>
        /// <param name="dateDebutContrat"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        public MissionInterim(String agenceInterim, String motif, DateTime dateFinContrat, String qualification, DateTime dateDebutContrat, Statut statut, Decimal salaireBrut) : base(motif, dateFinContrat, qualification, dateDebutContrat, statut, salaireBrut)
        {
            AgenceInterim = agenceInterim;
        }


        public String AgenceInterim
        {
            get
            {
                return agenceInterim;
            }
            set
            {
                if (!Tools.IsNameValid(value) || !Tools.isNameOnlyChar(value)) throw new Exception("Nom de l'agence incorrect");
                else {
                    if (this.agenceInterim != value) this.agenceInterim = value;
                }
            }
        }

        public override String ToString()
        {
            return "Mission Interim : " + base.ToString() + "\nAgence Interim : " + agenceInterim;
        }

    }
}