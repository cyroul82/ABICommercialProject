/***********************************************************************
 * Module:  Cdi.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdi
 ***********************************************************************/

using System;

namespace ABIModel
{
    public class Cdi : Contrat
    {
        private DateTime dateCloture;

        public Cdi()
        {

        }
        public Cdi(String qualification, DateTime dateDebutContrat, Statut statut, Decimal salaireBrut) : base(qualification, dateDebutContrat, statut, salaireBrut)
        {
        }

        /// <summary>
        /// Return 
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "CDI : " + base.ToString();
        }

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