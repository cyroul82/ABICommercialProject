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
            try
            {
                collaborateur = collaborateurForm.getCollaborateur();
                DAO.getInstance().UpdateCollaborateur(collaborateur);
                collaborateurForm.closeDialog();
                UpdatingCollabo?.Invoke(collaborateur);
            }
            catch (Exception ex)
            {
                collaborateurForm.displayErrorMessage(ex.Message, "Error Updating Collaborateur");

            }
        }

        public void init()
        {
            collaborateurForm.displayDialog();
        }
    }
}
