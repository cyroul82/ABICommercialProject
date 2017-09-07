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
            CtrlNewContrat ctrlNewContrat = new CtrlNewContrat(collaborateur);
            ctrlNewContrat.SavingContrat += new ContratHandler(this.onSavedContrat);
            ctrlNewContrat.init();
        }

        private void onSavedContrat(Contrat contrat)
        {
            this.contrat = contrat;
            this.savingNewCollaborateur();
        }

        private void savingNewCollaborateur()
        {
            collaborateur.Matricule = MainApp.matricule++;
            Random r = new Random();
            Int32 i = r.Next(1001, 10000);
            contrat.NumeroContrat = i;
            collaborateur.setContratActif(contrat);
            collaborateur.AddContrat(contrat);
            SavingCollaboData?.Invoke(collaborateur);
            this.collaborateurForm.Close();
        }

        public void init()
        {
            collaborateurForm.displayDialog();
        }
        
    }
}
