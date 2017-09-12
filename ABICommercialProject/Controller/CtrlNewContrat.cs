using ABICommercialProject.Model;
using ABICommercialProject.View;


namespace ABICommercialProject.Controller
{
    public class CtrlNewContrat
    {
        private Collaborateur collaborateur;
        private ContratForm cf;

        public ContratHandler SavingContrat;
        public CtrlNewContrat(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            cf = new ContratForm();
            cf.SavingContrat += new ContratHandler(this.onSavedContrat);
        }

        public void init()
        {   if (cf != null)
            {
                cf.ShowDialog();
            }
        }

        private void onSavedContrat(Contrat contrat)
        {
            if (contrat != null)
            {
                SavingContrat?.Invoke(contrat);
            }
        }
    }
}
