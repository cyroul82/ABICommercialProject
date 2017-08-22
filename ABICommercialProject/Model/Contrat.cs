/***********************************************************************
 * Module:  Contrat.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Contrat
 ***********************************************************************/

using System;

namespace ABICommercialProject
{
    public abstract class Contrat
    {
        private decimal salaireBrut;
        private String qualification;
        private DateTime dateDebutContrat;

        private Statut statut;
        private System.Collections.ArrayList avenant;

        public Contrat(String qualification, DateTime dateDebutContrat, Statut statut, Decimal salaireBrut)
        {
            // TODO: implement
        }

        public Statut getStatut()
        {
            // TODO: implement
            return statut;
        }

        public void setStatut(Statut statut)
        {
            // TODO: implement
            this.statut = statut;
        }

        public override String ToString()
        {
            // TODO: implement
            return null;
        }

        public void AddAvenant(Avenant newAvenant)
        {
            if (newAvenant == null)
                return;
            if (this.avenant == null)
                this.avenant = new System.Collections.ArrayList();
            if (!this.avenant.Contains(newAvenant))
                this.avenant.Add(newAvenant);
        }

        public decimal SalaireBrut
        {
            get
            {
                return salaireBrut;
            }
            set
            {
                if (this.salaireBrut != value)
                    this.salaireBrut = value;
            }
        }

        public String Qualification
        {
            get
            {
                return qualification;
            }
            set
            {
                if (this.qualification != value)
                    this.qualification = value;
            }
        }

        public DateTime DateDebutContrat
        {
            get
            {
                return dateDebutContrat;
            }
            set
            {
                if (this.dateDebutContrat != value)
                    this.dateDebutContrat = value;
            }
        }

    }
}