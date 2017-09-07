using ABICommercialProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABICommercialProject.Controller
{
    public class CtrlListContrat
    {
        ContratListForm contratListForm;
        public CtrlListContrat(SortedDictionary<Int32, Contrat> listContrat)
        {
            contratListForm = new ContratListForm(listContrat);
            contratListForm.CloturingContrat += new ContratHandler(this.onCloturedContrat);
            contratListForm.CreatingContrat += new EventHandler(this.onCreatedContrat);
            contratListForm.ShowDialog();
        }

        private void onCreatedContrat(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onCloturedContrat(Contrat contrat)
        {
            throw new NotImplementedException();
        }
    }
}
