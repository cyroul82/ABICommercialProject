using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABICommercialProject.Controller
{
    class CollaborateurController
    {
        private SortedDictionary<Int32, Collaborateur> collaborateurList;
        private static Int32 matriculeCount;

        public static CollaborateurController instance; 
        private CollaborateurController()
        {
            collaborateurList = new SortedDictionary<Int32, Collaborateur>();
            matriculeCount = 0;
        }

        public static CollaborateurController getCollaboInstance()
        {
            if(instance == null)
            {
                instance = new CollaborateurController();
            }
            return instance;
        }

        public Collaborateur getCollaborateur(Int32 matricule)
        {
            if (collaborateurList.ContainsKey(matricule))
            {
                return collaborateurList[matricule];
            }
            else return null;
        }

        public SortedDictionary<Int32, Collaborateur> getCollaborateurList()
        {
            return collaborateurList;
        }

        public void newCollaborateur(Collaborateur collaborateur, Contrat contrat)
        {
            if (contrat == null || collaborateur == null)
            {
                if (contrat == null)
                {
                    throw new Exception("contrat is null, impossible to create a collaborateur");
                }
                if (collaborateur == null)
                {
                    throw new Exception("collaborateur is null...");
                }
            }
            else
            {
                try
                {
                    collaborateur.AddContrat(contrat);
                    matriculeCount++;
                    collaborateur.Matricule = matriculeCount;
                    collaborateurList.Add(collaborateur.Matricule, collaborateur);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            

        }
    }
}
