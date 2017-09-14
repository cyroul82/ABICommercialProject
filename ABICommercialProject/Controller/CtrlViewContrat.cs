using ABICommercialProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABICommercialProject.Model;

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
            cf.CloturingContrat += new EventHandler(this.onCloturedContrat);
        }


        public void init()
        {
            cf?.ShowDialog();
        }

        private void onCloturedContrat(object sender, EventArgs e)
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
