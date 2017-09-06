/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Collaborateur
 ***********************************************************************/

using ABICommercialProject.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ABICommercialProject
{
    public class Collaborateur
    {

        private int matricule;
        private String nomCollabo;
        private String prenomCollabo;
        private String photographie;
        private String fonctionCollabo;
        private Boolean statut;
        private Contrat contratActif;

        private SortedDictionary<Int32, Contrat> listContrat;

        private List<AugmentationSalaire> listAugmentationSalaire;

        /// <summary>
        /// Constructor to instanciate a collaborateur 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="fonctionCollabo"></param>
        public Collaborateur(String nom, String prenom, String fonctionCollabo, Contrat contratActif)
        {
            initializeConstuctor(nom, prenom, fonctionCollabo);
            statut = true;
        }
        public Collaborateur(String nom, String prenom, String fonctionCollabo)
        {
            initializeConstuctor(nom, prenom, fonctionCollabo);
            statut = true;
            contratActif = null;
        }
        /// <summary>
        /// Initialize properties
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="fonctionCollabo"></param>
        private void initializeConstuctor(String nom, String prenom, String fonctionCollabo)
        {
            Matricule = 0;
            NomCollabo = nom;
            PrenomCollabo = prenom;
            FonctionCollabo = fonctionCollabo;
            this.listContrat = new SortedDictionary<Int32, Contrat>();
            this.listAugmentationSalaire = new List<AugmentationSalaire>();

        }

        /// <summary>
        /// do something unknown so far !
        /// </summary>
        /// <param name="listAugmentation"></param>
        /// <returns></returns>
        public Decimal calculerAugmentation()
        {
            Decimal tauxTotal = 0;
            foreach(AugmentationSalaire augmentation in listAugmentationSalaire)
            {
                tauxTotal += augmentation.Taux;
            }

            return 0;
        }

        /// <summary>
        /// Display the collaborateur
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Collaborateur : " + nomCollabo + " " + prenomCollabo + " " + fonctionCollabo;
        }

        /// <summary>
        /// Add a new contract
        /// </summary>
        /// <param name="contrat"></param>
        /// <exception cref="Exception">Error Contract Existing</exception>
        /// <exception cref="ArgumentNullException">Contract is Null</exception>
        public void AddContrat(Contrat contrat)
        {
            if(contratActif == null)
            {
                if (contrat == null)
                {
                    throw new NullReferenceException("Impossible to add a contract null");
                }
                else 
                {
                    if (!this.listContrat.ContainsKey(contrat.NumeroContrat))
                    {
                        this.listContrat.Add(contrat.NumeroContrat, contrat);
                        this.contratActif = contrat;
                    }
                    else
                    {
                        throw new Exception("The contract list has already a contrat with the same number");
                    }
                }
            }
            else
            {
                throw new Exception("Le collaborateur " + this.nomCollabo + " posséde déjà un contrat actif");
            }
            
        }

        public SortedDictionary<Int32, Contrat> getListContrat()
        {
            return listContrat;
        }

        /// <summary>
        /// Cloture le contrat actif, avec une date de date fin effective et un motif
        /// </summary>
        /// <param name="contrat"></param>
        /// <exception cref="ArgumentNullException">contrat actif is null</exception>
        public void clotureContratActif(DateTime dateFinEffectif, String motifCloture)
        {
            if (contratActif != null)
            {
                contratActif.clotureContrat(dateFinEffectif, motifCloture);
                this.contratActif = null;
                this.statut = false;
            }
            else
            {
                throw new NullReferenceException("Le collaborateur n'a aucun contrat actif à cloturer");
            }
        }

        /// <summary>
        /// Return True if the collaborateur has a Contrat Actif, false otherwise
        /// </summary>
        /// <returns></returns>
        public Boolean hasContratActif()
        {
            return contratActif == null ? false : true;
        }

        /// <summary>
        /// Return the contract actif of the collaborateur
        /// </summary>
        /// <returns></returns>
        public Contrat getContratActif()
        {
            return contratActif;
        }

        /// <summary>
        /// Set the contrat actif 
        /// </summary>
        /// <param name="contrat"></param>
        public void setContratActif(Contrat contrat)
        {
            this.contratActif = contrat != null ? contrat : null;
            if(contratActif != null)
            {
                listContrat.Add(contrat.NumeroContrat, contrat);
            }
        }

        
        /// <summary>
        /// Add a pay rise
        /// </summary>
        /// <param name="augmentation"></param>
        /// <exception cref="ArgumentNullException">Null Augmentation</exception>
        /// <exception cref="Exception">Augmentation Existing</exception>
        public void AddAugmentationSalaire(AugmentationSalaire augmentation)
        {
            if (augmentation == null)
            {
                throw new NullReferenceException("Augmentation is null");
            }

            else {
                if (!this.listAugmentationSalaire.Contains(augmentation))
                { 
                    this.listAugmentationSalaire.Add(augmentation);
                }
                else
                {
                    throw new Exception("Augmentation already Exist");
                }
            }
        }
        /// <summary>
        /// Propriété {get; set}, convertit en majuscule
        /// </summary>
        public String NomCollabo
        {
            get
            {
                return nomCollabo;
            }
            set
            {
     
                if (this.nomCollabo != value)
                    this.nomCollabo = value.ToUpper().Trim();
                
            }
        }

        /// <summary>
        /// Propriété {get ; set} 
        /// </summary>
        /// <exception cref="Exception">prenom n'est pas valide</exception>
        public String PrenomCollabo
        {
            get
            {
                return prenomCollabo;
            }
            set
            {
                if (!Tools.IsNameValid(value))
                {
                    throw new Exception("The surname lenght must be greater than 2 letters");
                }
                if (!Tools.isNameOnlyChar(value))
                {
                    throw new Exception("the surname must contains only characters");
                }
                if (this.prenomCollabo != value)
                    this.prenomCollabo = value;
            }
        }

        public String Photographie
        {
            get
            {
                return photographie;
            }
            set
            {
                if (this.photographie != value)
                    this.photographie = value;
            }
        }

        public String FonctionCollabo
        {
            get
            {
                return fonctionCollabo;
            }
            set
            {
                if (!Tools.IsNameValid(value))
                {
                    throw new ArgumentException("The surname lenght must be greater than 2 letters");
                }
                if (!Tools.isNameOnlyChar(value))
                {
                    throw new ArgumentException("the surname must contains only characters");
                }
                if (this.fonctionCollabo != value)
                    this.fonctionCollabo = value;
            }
        }

        public int Matricule
        {
            get
            {
                return matricule;
            }
            set
            {
                if (this.matricule != value)
                    this.matricule = value;
            }
        }

        public Boolean Statut
        {
            get
            {
                return statut;
            }
            set
            {
                if (this.statut != value)
                    this.statut = value;
            }
        }
    }
}