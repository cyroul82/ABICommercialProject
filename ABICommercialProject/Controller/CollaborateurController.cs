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
        
        public CollaborateurController()
        {
            
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
                    Collaborateur.collaborateurList.Add(collaborateur.Matricule, collaborateur);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            

        }
    }
}
