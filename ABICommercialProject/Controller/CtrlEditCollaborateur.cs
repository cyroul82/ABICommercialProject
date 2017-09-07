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

        public CollaboHandler UpdatingCollabo;
		public CtrlEditCollaborateur(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            this.collaborateurForm = new CollaborateurForm(collaborateur, true);
            collaborateurForm.UpdatingCollabo += new EventHandler(this.onUpdatedCollabo);
        }

        private void onUpdatedCollabo(object sender, EventArgs e)
        {
            if (collaborateur != null)
            {
                collaborateur = collaborateurForm.getCollaborateur();
                collaborateurForm.closeDialog();
                UpdatingCollabo?.Invoke(collaborateur);
            }
            else
            {
                collaborateurForm.displayErrorMessage("Unexpected Error, Contrat or Collaborateur is null", "Error App");
            }
        }

        public void init()
        {
            collaborateurForm.displayDialog();
        }
    }
}
