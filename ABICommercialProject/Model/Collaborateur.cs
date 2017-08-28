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
        public static SortedDictionary<Int32, Collaborateur> collaborateurList = new SortedDictionary<Int32, Collaborateur>();
        public static Int32 matriculeCount = 0;

        private int matricule;
        private String nomCollabo;
        private String prenomCollabo;
        private String photographie;
        private String fonctionCollabo;
        private System.Boolean statut;
        private Contrat contratActif;

        private SortedDictionary<Int32, Contrat> listContrat;

        private List<AugmentationSalaire> listAugmentationSalaire;


        public Collaborateur(String nom, String prenom, String fonctionCollabo)
        {
            NomCollabo = nom;
            PrenomCollabo = prenom;
            FonctionCollabo = fonctionCollabo;
            this.listContrat = new SortedDictionary<Int32, Contrat>();
            this.listAugmentationSalaire = new List<AugmentationSalaire>();
            ContratActif = null;

            Matricule = matriculeCount;
            matriculeCount++;
        }

        /// <summary>
        /// do something unknown so far !
        /// </summary>
        /// <param name="listAugmentation"></param>
        /// <returns></returns>
        public int calculerAugmentation(AugmentationSalaire listAugmentation)
        {
            // TODO: implement
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
        public void AddContrat(Contrat contrat)
        {
            if(contratActif == null)
            {
                if (contrat == null)
                    return;
                if (this.listContrat == null)
                    this.listContrat = new SortedDictionary<Int32, Contrat>();
                if (!this.listContrat.ContainsKey(contrat.NumeroContrat))
                    this.listContrat.Add(contrat.NumeroContrat, contrat);
            }
            else
            {
                throw new Exception("Le collaborateur " + this.nomCollabo + " posséde déjà un contrat actif");
            }
            
        }

        public void FinishContrat(Contrat contrat)
        {
            if(contrat == null)
            {

            }
            if(contrat is Cdi)
            {
                Cdi c = contrat as Cdi;
                
            }
            this.contratActif = null;
        }
        
        /// <summary>
        /// Add a pay rise
        /// </summary>
        /// <param name="augmentation"></param>
        public void AddAugmentationSalaire(AugmentationSalaire augmentation)
        {
            if (augmentation == null)
                return;
            if (this.listAugmentationSalaire == null)
                this.listAugmentationSalaire = new List<AugmentationSalaire>();
            if (!this.listAugmentationSalaire.Contains(augmentation))
                this.listAugmentationSalaire.Add(augmentation);
        }

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
                    throw new Exception("The surname lenght must be greater than 2 letters");
                }
                if (!Tools.isNameOnlyChar(value))
                {
                    throw new Exception("the surname must contains only characters");
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

        public System.Boolean Statut
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