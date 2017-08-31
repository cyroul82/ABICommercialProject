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
    public delegate void SavedCollaboHandler(Collaborateur collabo);
    public class CtrlNewCollaborateur
    {
        public SavedCollaboHandler onSavedCollabo;

        private CollaborateurForm collaborateurForm;
        public CtrlNewCollaborateur()
        {
            this.collaborateurForm = new CollaborateurForm();
            collaborateurForm.onSaved += new ActionSaveHandler(this.savingCollabo);
        }

        public void init()
        {
            collaborateurForm.displayDialog();
        }

        private void savingCollabo(String message)
        {
            if (message == Tools.save)
            {
                Collaborateur collaborateur = collaborateurForm.getCollaborateur();

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
    }
}
