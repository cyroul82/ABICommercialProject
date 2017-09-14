using ABICommercialProject.Model;
using ABICommercialProject.View;
using System;

namespace ABICommercialProject.Controller
{
    
    public class CtrlNewCollaborateur
    {
        private Collaborateur collaborateur;
        private Contrat contrat;

        public CollaboHandler SavingCollaboData;

        private CollaborateurForm collaborateurForm;
        public CtrlNewCollaborateur()
        {
            this.collaborateurForm = new CollaborateurForm();
            collaborateurForm.SavingCollabo += new EventHandler(this.onSavedCollabo);
        }

        private void onSavedCollabo(object sender, EventArgs e)
        {
            collaborateur = collaborateurForm.getCollaborateur();
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
                collaborateurForm.displayErrorMessage(ex.Message, "Error DB");
            }
        }

        private void savingNewCollaborateur()
        {
            
        }

        public void init()
        {
            collaborateurForm.displayDialog();
        }
        
    }
}
