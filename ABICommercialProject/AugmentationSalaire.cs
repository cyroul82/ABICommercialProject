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

        public AugmentationSalaire(DateTime date, Decimal taux)
        {
            this.date = date;
            this.taux = taux;
        }

        public override String ToString()
        {
            // TODO: implement
            return null;
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