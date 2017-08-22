/***********************************************************************
 * Module:  Avenant.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Avenant
 ***********************************************************************/

using System;

namespace ABICommercialProject
{
    public class Avenant
    {
        public Avenant(DateTime dateAvenant)
        {
            this.dateAvenant = dateAvenant;
        }

        public override String ToString()
        {
            //TODO implement
            return null;
        }

        private DateTime dateAvenant;
        private String libelle;

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

    }
}