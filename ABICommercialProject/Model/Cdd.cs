/***********************************************************************
 * Module:  Cdd.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdd
 ***********************************************************************/

using System;

namespace ABICommercialProject
{
    public class Cdd : ContratProvisoire
    {
        public Cdd(String motif, DateTime dateFinContrat, String qualification, DateTime dateDebutContrat, Statut statut, Decimal salaireBrut) : base(motif, dateFinContrat, qualification, dateDebutContrat, statut, salaireBrut)
        {
            // TODO: implement
        }

        public override String ToString()
        {
            // TODO: implement
            return null;
        }

    }
}