/***********************************************************************
 * Module:  Cdd.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdd
 ***********************************************************************/

using System;

namespace ABICommercialProject.Model
{
    public class Cdd : ContratProvisoire
    {

        public Cdd()
        {

        }

        /// <summary>
        /// Construtor to instanciate a CDD 
        /// </summary>
        /// <param name="motif"></param>
        /// <param name="dateFinContrat"></param>
        /// <param name="qualification"></param>
        /// <param name="dateDebutContrat"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        public Cdd(String motif, DateTime dateFinContrat, String qualification, DateTime dateDebutContrat, Statut statut, Decimal salaireBrut) : base(motif, dateFinContrat, qualification, dateDebutContrat, statut, salaireBrut)
        {
        }



        public override String ToString()
        {
            return "CDD : " + base.ToString();
        }

    }
}