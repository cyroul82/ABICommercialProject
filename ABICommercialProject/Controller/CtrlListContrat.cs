using ABICommercialProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABICommercialProject.Controller
{
    public class CtrlListContrat
    {
        ContratListForm contratListForm;
        SortedDictionary<Int32, Contrat> listContrat;
        Collaborateur collaborateur;
        public CtrlListContrat(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            listContrat = collaborateur.getListContrat();
            contratListForm = new ContratListForm(listContrat);
            contratListForm.CloturingContrat += new ContratHandler(this.onCloturedContrat);
            contratListForm.CreatingContrat += new EventHandler(this.onCreatedContrat);
            contratListForm.SelectingContrat += new SelectingHandler(this.onSelectedContrat);
            contratListForm.ShowDialog();
        }

        private void onSelectedContrat(int id)
        {
            if (listContrat.ContainsKey(id))
            {
                CtrlViewContrat ctrlViewContrat = new CtrlViewContrat(listContrat[id]);
                ctrlViewContrat.CloturingContrat += new ContratHandler(this.onCloturedContrat);
                ctrlViewContrat.init();
            }
        }

        private void onCreatedContrat(object sender, EventArgs e)
        {
            if (!collaborateur.hasContratActif())
            {
                CtrlNewContrat ctrlNewContrat = new CtrlNewContrat(collaborateur);
                ctrlNewContrat.init();
            }
            else
            {
                MessageBox.Show("Contrat actif déja existant, clôturer le contrat actif", "Erreur Contrat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void onCloturedContrat(Contrat contrat)
        {
            if(contrat == collaborateur.getContratActif())
            {
                collaborateur.setContratActif(null);
                collaborateur.getListContrat()[contrat.NumeroContrat] = contrat;
            }
        }
    }
}
