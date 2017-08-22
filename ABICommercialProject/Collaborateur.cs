/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Collaborateur
 ***********************************************************************/

using System;

namespace ABICommercialProject
{
    public class Collaborateur
    {
        public static System.Collections.ArrayList collaborateur = new System.Collections.ArrayList();

        private int matricule;
        private String nomCollabo;
        private String prenomCollabo;
        private String photographie;
        private String fonctionCollabo;
        private System.Boolean statut;

        private System.Collections.ArrayList contrat;

        private System.Collections.ArrayList augmentationSalaire;

        public Collaborateur(String nom, String prenom, String fonctionCollabo)
        {
            this.nomCollabo = nom;
            this.prenomCollabo = prenom;
            this.fonctionCollabo = fonctionCollabo;
            this.contrat = new System.Collections.ArrayList();
            this.augmentationSalaire = new System.Collections.ArrayList();
            
        }


        public int calculerAugmentation(AugmentationSalaire listAugmentation)
        {
            // TODO: implement
            return 0;
        }

        public override string ToString()
        {
            return "Collaborateur : " + nomCollabo + " " + prenomCollabo + " " + fonctionCollabo;
        }

        public void AddContrat(Contrat newContrat)
        {
            if (newContrat == null)
                return;
            if (this.contrat == null)
                this.contrat = new System.Collections.ArrayList();
            if (!this.contrat.Contains(newContrat))
                this.contrat.Add(newContrat);
        }
        
        public void AddAugmentationSalaire(AugmentationSalaire newAugmentationSalaire)
        {
            if (newAugmentationSalaire == null)
                return;
            if (this.augmentationSalaire == null)
                this.augmentationSalaire = new System.Collections.ArrayList();
            if (!this.augmentationSalaire.Contains(newAugmentationSalaire))
                this.augmentationSalaire.Add(newAugmentationSalaire);
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
                    this.nomCollabo = value;
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

    }
}