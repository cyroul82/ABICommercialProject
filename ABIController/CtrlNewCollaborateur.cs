using ABIDAO;
using ABIModel;
using ABIView;
using System;

namespace ABIController
{
    
    public class CtrlNewCollaborateur
    {
        private Collaborateur collaborateur;
        private CollaborateurForm collaborateurForm;

        public CollaboHandler SavingCollabo;

        /// <summary>
        /// Constructor, instanciate the Collaborateur Form
        /// Listen to the SavingCollabo Event
        /// </summary>
        public CtrlNewCollaborateur()
        {
            this.collaborateurForm = new CollaborateurForm();
            collaborateurForm.SavingCollabo += new CollaboHandler(this.OnSavedCollabo);
        }

        public void Init()
        {
            collaborateurForm.DisplayDialog();
        }

        private void OnSavedCollabo(Collaborateur collabo)
        {
            if (collabo!= null)
            {
                this.collaborateur = collabo;
                CtrlNewContrat ctrlNewContrat = new CtrlNewContrat(collabo);
                ctrlNewContrat.SavingContrat += new EventHandler(this.OnSavedContrat);
                ctrlNewContrat.Init();
            }
        }

        private void OnSavedContrat(object sender, EventArgs e)
        {
            if (collaborateur != null)
            {
                SavingCollabo?.Invoke(collaborateur);
                //close the form
                this.collaborateurForm.Close();
            }
        }
    }
}
