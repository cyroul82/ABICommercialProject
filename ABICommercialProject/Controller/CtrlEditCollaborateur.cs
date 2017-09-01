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
        private Collaborateur collaborateur;
        private CollaborateurForm collaborateurForm;

        public SaveCollaboHandler SavingCollabo;
		public CtrlEditCollaborateur(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            this.collaborateurForm = new CollaborateurForm(collaborateur, true);

            collaborateurForm.SavingCollabo += new SaveHandler(this.onSavedCollaborateur);
            
        }

        public void init()
        {
            collaborateurForm.displayDialog();
        }

        private void onSavedCollaborateur(string message)
        {

            if (message == Tools.save)
            {

                if (collaborateur != null)
                {
                    SavingCollabo?.Invoke(collaborateurForm.getCollaborateur());
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
