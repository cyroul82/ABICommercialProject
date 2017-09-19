using ABICommercialProject.View;
using System;
using ABIModel;

namespace ABICommercialProject.Controller
{
    public class CtrlViewContrat
    {
        private ContratForm cf;
        public event EventHandler CloturingContrat;

        private Contrat contrat;

        public CtrlViewContrat(Contrat contrat)
        {
            cf = new ContratForm(contrat);
            this.contrat = contrat;
            cf.CloturingContrat += new EventHandler(this.OnCloturedContrat);
        }


        public void Init()
        {
            cf?.ShowDialog();
        }

        private void OnCloturedContrat(object sender, EventArgs e)
        {
            ClotureForm cf = new ClotureForm(ref contrat);
            if (cf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DAOToChange.getInstance().Update();
                CloturingContrat?.Invoke(sender, e);
            }
        }
    }
}
