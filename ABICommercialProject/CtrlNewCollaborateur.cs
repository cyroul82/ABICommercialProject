using ABIModel;
using ABIView;
using System;

namespace ABICommercialProjet
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

        public void DisplayForm()
        {
            collaborateurForm.DisplayDialog();
        }

        /// <summary>
        /// Method called when the event SavingCollabo is fired
        /// initialize a new instance of the class CtrlNewContrat
        /// </summary>
        /// <param name="collabo"></param>
        private void OnSavedCollabo(Collaborateur collabo)
        {
            if (collabo!= null)
            {
                this.collaborateur = collabo;
                CtrlNewContrat ctrlNewContrat = new CtrlNewContrat(collabo);
                ctrlNewContrat.SavingContrat += new EventHandler(this.OnSavedContrat);
                ctrlNewContrat.Display();
            }
        }

        /// <summary>
        /// Method called when the event SavingContrat is fired
        /// Raise the event SavingCollabo
        /// Close the form CollaboraturForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
