/***********************************************************************
 * Module:  AugmentationSalaire.cs
 * Author:  CDI14
 * Purpose: Definition of the Class AugmentationSalaire
 ***********************************************************************/

using System;

namespace ABIModel
{
    public class AugmentationSalaire
    {

        private DateTime date;
        private decimal taux;
        private Collaborateur collaborateur;
        private Int32 id;

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

        /// <summary>
        /// Propri�t� Date{get; set}
        /// </summary>
        /// <exception cref="Exception">Date inf�rieur � la date du jour</exception>
        public DateTime Date
        {
            get
            {
                return date;
            }
            private set
            {
                if (!Tools.isDateGreaterThanTodayDate(value)) throw new Exception("La date pour une augmentation ne peut �tre inf�rieure � la date du jour");
                if (this.date != value)
                    this.date = value;
            }
        }

        /// <summary>
        /// Propri�t� Taux{get; set}
        /// </summary>
        /// <exception cref="Exception">Taux inf�rieur ou �gal � 0</exception>
        public Decimal Taux
        {
            get
            {
                return taux;
            }
            private set
            {
                if (taux <= 0) throw new Exception("Le taux ne peut �tre �gal ou inf�rieur � 0");
                if (this.taux != value)
                    this.taux = value;
            }
        }

        public Collaborateur Collaborateur
        {
            get
            {
                return collaborateur;
            }

            set
            {
                collaborateur = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}