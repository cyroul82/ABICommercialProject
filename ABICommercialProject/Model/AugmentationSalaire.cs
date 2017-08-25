/***********************************************************************
 * Module:  AugmentationSalaire.cs
 * Author:  CDI14
 * Purpose: Definition of the Class AugmentationSalaire
 ***********************************************************************/

using System;

namespace ABICommercialProject
{
    public class AugmentationSalaire
    {
        private DateTime date;
        private decimal taux;

        /// <summary>
        /// Constructor to instanciate a new pay rise
        /// </summary>
        /// <param name="date"></param>
        /// <param name="taux"></param>
        public AugmentationSalaire(DateTime date, Decimal taux)
        {
            Date = date;
            Taux = taux;
        }

        /// <summary>
        /// Return the pay rise and the date
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "Augmentation Salaire : " + Taux + "\nDate : " + Date;
        }


        public DateTime Date
        {
            get
            {
                return date;
            }
            private set
            {
                if (this.date != value)
                    this.date = value;
            }
        }

        public decimal Taux
        {
            get
            {
                return taux;
            }
            private set
            {
                if (this.taux != value)
                    this.taux = value;
            }
        }
    }
}