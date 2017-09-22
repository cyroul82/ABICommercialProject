using ABIDAO;
using ABIModel;
using ABIView;
using System;
using System.Windows.Forms;

namespace ABIController
{
    public class CtrlNewContrat
    {
        private Collaborateur collaborateur;
        private ContratForm cf;

        public EventHandler SavingContrat;
        public CtrlNewContrat(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            cf = new ContratForm();
            cf.SavingContrat += new ContratHandler(this.OnSavedContrat);
        }

        public void Init()
        {   if (cf != null)
            {
                cf.ShowDialog();
            }
        }

        private void OnSavedContrat(Contrat contrat)
        {
            if (contrat != null)
            {
                try
                {
                    collaborateur.AddContrat(contrat);
                    SavingContrat?.Invoke(this, new EventArgs());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
