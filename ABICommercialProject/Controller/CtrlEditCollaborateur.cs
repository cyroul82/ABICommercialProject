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

            collaborateurForm.onSaved += new ActionClickSave(this.clickEvent);
            collaborateurForm.displayDialog();
        }

        private void clickEvent(string message)
        {
            //throw new NotImplementedException();
        }
    }
}
