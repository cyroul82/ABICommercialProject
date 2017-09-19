/***********************************************************************
 * Module:  Avenant.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Avenant
 ***********************************************************************/

using System;

namespace ABIModel
{
    public class Avenant
    {
        private DateTime dateAvenant;
        private String libelle;
        private Int32 numeroAvenant;

        public Avenant(DateTime dateAvenant)
        {
            DateAvenant = dateAvenant;
        }

        /// <summary>
        /// Return l'avenant and the date
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "Avenant : " + DateAvenant;
        }

        public DateTime DateAvenant
        {
            get
            {
                return dateAvenant;
            }
            set
            {
                if (this.dateAvenant != value)
                    this.dateAvenant = value;
            }
        }

        public String Libelle
        {
            get
            {
                return libelle;
            }
            set
            {
                if (this.libelle != value)
                    this.libelle = value;
            }
        }

        public int NumeroAvenant
        {
            get
            {
                return numeroAvenant;
            }

            set
            {
                numeroAvenant = value;
            }
        }
    }
}