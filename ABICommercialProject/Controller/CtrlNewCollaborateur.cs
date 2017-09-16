using ABICommercialProject.Model;
using ABICommercialProject.View;
using System;

namespace ABICommercialProject.Controller
{
    
    public class CtrlNewCollaborateur
    {
        private Collaborateur collaborateur;

        public CollaboHandler SavingCollaboData;

        private CollaborateurForm collaborateurForm;
        public CtrlNewCollaborateur()
        {
            this.collaborateurForm = new CollaborateurForm();
            collaborateurForm.SavingCollabo += new EventHandler(this.onSavedCollabo);
        }

        public void init()
        {
            collaborateurForm.DisplayDialog();
        }

        private void onSavedCollabo(object sender, EventArgs e)
        {
            collaborateur = collaborateurForm.GetCollaborateur();
            if (collaborateur != null)
            {
                CtrlNewContrat ctrlNewContrat = new CtrlNewContrat(ref collaborateur);
                ctrlNewContrat.SavingContrat += new EventHandler(this.onSavedContrat);
                ctrlNewContrat.init();
            }
        }

        private void onSavedContrat(object sender, EventArgs e)
        {
            try
            {
                DAOToChange.getInstance().NewCollaborateur(ref collaborateur);
                SavingCollaboData?.Invoke(collaborateur);
                //close the form
                this.collaborateurForm.Close();
            }
            catch (Exception ex)
            {
                collaborateurForm.DisplayErrorMessage(ex.Message, "Error DB");
            }
        }
    }
}
