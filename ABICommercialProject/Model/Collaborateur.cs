/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Collaborateur
 ***********************************************************************/

using ABICommercialProject.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ABICommercialProject.Model
{
    public class Collaborateur
    {

        private int id;
        private String name;
        private String firstname;
        private String picture;
        private String fonction;
        private String address;
        private String zipCode;
        private String town;
        private String tel;
        private String email;
        private Boolean statut;
        private Contrat contratActif;

        //private IDictionary<Int32, Contrat> contrats;
        private ICollection<Contrat> contrats;

        private List<AugmentationSalaire> augmentations;

        /// <summary>
        /// Constructor to instanciate a collaborateur 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="fonctionCollabo"></param>
        public Collaborateur() { }
        public Collaborateur(String nom, String prenom, String fonctionCollabo, String address, String zipCode, String town, String tel, String email)
        {
            Id = 0;
            Name = nom;
            Firstname = prenom;
            FonctionCollabo = fonctionCollabo;
            Address = address;
            ZipCode = zipCode;
            Town = town;
            Tel = tel;
            Email = email;
            statut = true;
            ContratActif = null;
            init();
        }
        public Collaborateur(Int32 matricule, String nom, String prenom, String fonctionCollabo, String address, String zipCode, String town, String tel, String email, Contrat contratActif, Boolean statut)
        {
            Id = matricule;
            Name = nom;
            Firstname = prenom;
            FonctionCollabo = fonctionCollabo;
            Address = address;
            ZipCode = zipCode;
            Town = town;
            Tel = tel;
            Email = email;
            this.Statut = statut;
            this.ContratActif = contratActif;
            init();
        }

        /// <summary>
        /// Initialize properties
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="fonctionCollabo"></param>
        private void init()
        {

            //this.Contrats = new SortedDictionary<Int32, Contrat>();
            this.Contrats = new HashSet<Contrat>();
            this.augmentations = new List<AugmentationSalaire>();

        }

        /// <summary>
        /// do something unknown so far !
        /// </summary>
        /// <param name="listAugmentation"></param>
        /// <returns></returns>
        public Decimal calculerAugmentation()
        {
            Decimal tauxTotal = 0;
            foreach(AugmentationSalaire augmentation in augmentations)
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
            return "Collaborateur : " + name + " " + firstname + " " + fonction;
        }

        /// <summary>
        /// Add a new contract
        /// </summary>
        /// <param name="contrat"></param>
        /// <exception cref="Exception">Error Contract Existing</exception>
        /// <exception cref="ArgumentNullException">Contract is Null</exception>
        public void AddContrat(Contrat contrat)
        {
            if(contrat != null)
            {
                Contrats.Add(contrat);
            }
            
        }

        //public ICollection<Contrat> getListContrat()
        //{
        //    return Contrats;
        //}

        /// <summary>
        /// Cloture le contrat actif, avec une date de date fin effective et un motif
        /// </summary>
        /// <param name="contrat"></param>
        /// <exception cref="ArgumentNullException">contrat actif is null</exception>
        public void clotureContratActif(DateTime dateFinEffectif, String motifCloture)
        {
            if (ContratActif != null)
            {
                ContratActif.clotureContrat(dateFinEffectif, motifCloture);
                this.ContratActif = null;
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
            return ContratActif == null ? false : true;
        }

        /// <summary>
        /// Return the contract actif of the collaborateur
        /// </summary>
        /// <returns></returns>
        public Contrat getContratActif()
        {
            return ContratActif;
        }

        /// <summary>
        /// Set the contrat actif 
        /// </summary>
        /// <param name="contrat"></param>
        public void setContratActif(Contrat contrat)
        {
            this.ContratActif = contrat != null ? contrat : null;
            //if(contratActif != null)
            //{
            //    listContrat.Add(contrat.NumeroContrat, contrat);
            //}
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
                if (!this.augmentations.Contains(augmentation))
                { 
                    this.augmentations.Add(augmentation);
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
        public String Name
        {
            get
            {
                return name;
            }
            set
            {

                if (!Tools.IsNameValid(value))
                {
                    throw new Exception("The surname lenght must be greater than 2 letters");
                }
                else if (!Tools.isNameOnlyChar(value))
                {
                    throw new Exception("the surname must contains only characters");
                }
                else if (this.name != value)
                    this.name = value.ToUpper().Trim();
                
            }
        }

        /// <summary>
        /// Propriété {get ; set} 
        /// </summary>
        /// <exception cref="Exception">prenom n'est pas valide</exception>
        public String Firstname
        {
            get
            {
                return firstname;
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
                if (this.firstname != value)
                    this.firstname = value;
            }
        }

        public String Picture
        {
            get
            {
                return picture;
            }
            set
            {
                if (this.picture != value)
                    this.picture = value;
            }
        }

        public String FonctionCollabo
        {
            get
            {
                return fonction;
            }
            set
            {
                if (this.fonction != value)
                    this.fonction = value;
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
                if (this.id != value)
                    this.id = value;
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

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string ZipCode
        {
            get
            {
                return zipCode;
            }

            set
            {
                zipCode = value;
            }
        }

        public string Town
        {
            get
            {
                return town;
            }

            set
            {
                town = value;
            }
        }

        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public virtual ICollection<Contrat> Contrats
        {
            get
            {
                return contrats;
            }

            set
            {
                contrats = value;
            }
        }

        public Contrat ContratActif
        {
            get
            {
                return contratActif;
            }

            set
            {
                contratActif = value;
            }
        }
    }
}