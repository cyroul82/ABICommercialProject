/***********************************************************************
 * Module:  Cdi.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdi
 ***********************************************************************/

using System;

namespace ABICommercialProject
{
    public class Cdi : Contrat
    {
        public Cdi(String qualification, DateTime dateDebutContrat, Statut statut, Decimal salaireBrut) : base(qualification, dateDebutContrat, statut, salaireBrut)
        {
            // TODO: implement
        }

        public override String ToString()
        {
            // TODO: implement
            return null;
        }

        private DateTime dateCloture;

        public DateTime DateCloture
        {
            get
            {
                return dateCloture;
            }
            set
            {
                if (this.dateCloture != value)
                    this.dateCloture = value;
            }
        }

    }
}