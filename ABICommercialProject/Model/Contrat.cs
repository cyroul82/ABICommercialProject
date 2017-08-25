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
        private Int32 numeroContrat;

        private Statut statutContrat;
        private System.Collections.ArrayList avenant;

        /// <summary>
        /// Constructor to instanciate a Contract
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="dateDebutContrat"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        public Contrat(String qualification, DateTime dateDebutContrat, Statut statut, Decimal salaireBrut)
        {
            Qualification = qualification;
            SalaireBrut = salaireBrut;
            DateDebutContrat = dateDebutContrat;
            StatutContrat = statut;
        }

        /// <summary>
        /// Add an Avenant to the contract
        /// </summary>
        /// <param name="newAvenant"></param>
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

        public Statut StatutContrat
        {
            get
            {
                return statutContrat;
            }

            set
            {
                statutContrat = value;
            }
        }

        public int NumeroContrat
        {
            get
            {
                return numeroContrat;
            }

            set
            {
                numeroContrat = value;
            }
        }

        /// <summary>
        /// Return contrat + qualif + date debut + statut + salaire
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "Contrat : "
                    + "\nQualification : " + qualification
                    + "\nDébut de listContrat : " + dateDebutContrat
                    + "\nStatut : " + StatutContrat
                    + "\nSalaire Brut : " + salaireBrut;
        }
    }
}