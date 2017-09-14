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
        ContratForm cf;
        public ContratHandler CloturingContrat;
        private Contrat contrat;

        public CtrlViewContrat(Contrat contrat)
        {
            cf = new ContratForm(contrat);
            this.contrat = contrat;
            cf.CloturingContrat += new ContratHandler(this.onCloturedContrat);
        }


        public void init()
        {
            cf?.ShowDialog();
        }

        private void onCloturedContrat(Contrat contrat)
        {
            ClotureForm cf = new ClotureForm(ref contrat);
            if (cf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DAOToChange.getInstance().Update();
                CloturingContrat?.Invoke(contrat);
            }
        }
    }
}
