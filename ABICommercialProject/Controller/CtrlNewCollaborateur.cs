using ABICommercialProject.Model;
using ABICommercialProject.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABICommercialProject.Controller
{
    
    public class CtrlNewCollaborateur
    {
        private Collaborateur collaborateur;
        public CollaboHandler onSavedCollabo;

        private CollaborateurForm collaborateurForm;
        public CtrlNewCollaborateur()
        {
            this.collaborateurForm = new CollaborateurForm();
            collaborateurForm.SavingCollabo += new SavingEventHandler(this.savingCollabo);
        }


        public void init()
        {
            collaborateurForm.displayDialog();
        }

        private void savingCollabo(String message)
        {
            if (message == Tools.save)
            {

                collaborateur = collaborateurForm.getCollaborateur();
                ContratForm cf = new ContratForm(collaborateur.getContratActif());
                cf.SavingContrat = new ContratHandler(this.onSavedContrat);                
                cf.ShowDialog();

                if (collaborateur != null)
                {
                    collaborateur.Matricule = MainApp.matricule++;
                    onSavedCollabo(collaborateur);
                    collaborateurForm.closeDialog();
                }
                else
                {
                    collaborateurForm.displayErrorMessage("Unexpected Error, Contrat or Collaborateur is null", "Error App");

                }
            }
        }

        private void onSavedContrat(Contrat contrat)
        {
            if(contrat != null && collaborateur != null)
            {
                collaborateur.Matricule = MainApp.matricule++;
                collaborateur.setContratActif(contrat);
                onSavedCollabo(collaborateur);
                collaborateurForm.closeDialog();
            }
            else
            {
                collaborateurForm.displayErrorMessage("Unexpected Error, Contrat or Collaborateur is null", "Error App");

            }

        }
    }
}
