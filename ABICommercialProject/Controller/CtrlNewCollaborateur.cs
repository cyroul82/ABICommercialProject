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
                CtrlNewContrat ctrlNewContrat = new CtrlNewContrat(collaborateur);
                ctrlNewContrat.SavingContrat += new ContratHandler(this.onSavedContrat);
                ctrlNewContrat.init();
            }
        }

        private void onSavedContrat(Contrat contrat)
        {
            if (contrat != null)
            {
                this.contrat = contrat;
                this.savingNewCollaborateur();
            }
        }

        private void savingNewCollaborateur()
        {
            try
            {
                DAO.getInstance().NewCollaborateur(ref collaborateur, contrat);
                //invoke savingCollaboData, The CtrlListColloborateur listening to it to update the list
                SavingCollaboData?.Invoke(collaborateur);
                //close the form
                this.collaborateurForm.Close();
            }
            catch (Exception e)
            {
                collaborateurForm.displayErrorMessage(e.Message, "Error DB");
            }
        }

        public void init()
        {
            collaborateurForm.displayDialog();
        }
        
    }
}
