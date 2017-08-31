using ABICommercialProject.Model;
using ABICommercialProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABICommercialProject.Controller
{
    public class CtrlEditCollaborateur
    {
        Collaborateur collaborateur;
        CollaborateurForm collaborateurForm;
		public CtrlEditCollaborateur(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            this.collaborateurForm = new CollaborateurForm(collaborateur, true);

            collaborateurForm.onSaved += new SaveHandler(this.clickEvent);
            
        }

        public void init()
        {
            collaborateurForm.displayDialog();
        }

        private void clickEvent(string message)
        {
            if (message == Tools.edit)
            {
                

                if (collaborateur != null)
                {
                    collaborateur.Matricule = MainApp.matricule++;
                    //onSavedCollabo(collaborateur);
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
