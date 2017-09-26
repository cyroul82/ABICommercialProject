/***********************************************************************
 * Module:  Contrat.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Contrat
 ***********************************************************************/

using System;
using System.Runtime.Serialization;

namespace ABIModel
{
    [Serializable]
    [DataContract]
    [KnownType(typeof(ContratProvisoire))]
    [KnownType(typeof(Cdi))]
    public abstract class Contrat
    {
        private decimal salaireBrut;
        private String qualification;
        private DateTime dateDebutContrat;
        private Int32 id;
        private DateTime? dateFinEffectif;
        private String motifCloture;
        private Boolean cloture;
        private Collaborateur collaborateur;

        private Statut statutContrat;
        private System.Collections.ArrayList avenant;

        public Contrat()
        {

        }
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
            DateFinEffectif = null;
            Id = 0;
            Cloture = false;
        }

        /// <summary>
        /// Add an Avenant to the contract
        /// </summary>
        /// <param name="newAvenant"></param>
        public void addAvenant(Avenant newAvenant)
        {
            if (newAvenant == null)
                return;
            if (!this.avenant.Contains(newAvenant))
                this.avenant.Add(newAvenant);
        }

        /// <summary>
        /// Cloture le contrat
        /// </summary>
        /// <param name="dateFinEffectif"></param>
        /// <param name="motifCloture"></param>
        public void clotureContrat(DateTime dateFinEffectif, String motifCloture)
        {
            if (dateFinEffectif < dateDebutContrat) throw new Exception("Date de fin ne peut pas etre inferieure à la date de début");
            else
            {
                this.DateFinEffectif = dateFinEffectif;
                this.MotifCloture = motifCloture;
                Cloture = true;
            }
        }

        [DataMember]
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

        [DataMember]
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

        [DataMember]
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

        /// <summary>
        /// Check that the numero isn't less than or equal to 0
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Contrat number lesser or equal than</exception>
        [DataMember]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                //if (value <= 0) throw new ArgumentOutOfRangeException("Le contract number can't be less or equal to 0");
                //else
                    id = value;
            }
        }

        [DataMember]
        public DateTime? DateFinEffectif
        {
            get
            {
                return dateFinEffectif;
            }

            set
            {
                dateFinEffectif = value;
            }
        }

        [DataMember]
        public string MotifCloture
        {
            get
            {
                return motifCloture;
            }

            set
            {
                motifCloture = value;
            }
        }

        [DataMember]
        public bool Cloture
        {
            get
            {
                return cloture;
            }

            set
            {
                cloture = value;
            }
        }

        [DataMember]
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