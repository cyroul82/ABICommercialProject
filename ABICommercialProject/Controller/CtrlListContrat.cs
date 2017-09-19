using ABICommercialProject.View;
using ABIModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABICommercialProject.Controller
{
    public class CtrlListContrat
    {
        private ContratListForm contratListForm;
        private Collaborateur collaborateur;

        public EventHandler Refreshing;
        public CtrlListContrat(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            contratListForm = new ContratListForm(collaborateur);
            contratListForm.CloturingContrat += new EventHandler(this.onCloturedContrat);
            contratListForm.CreatingContrat += new EventHandler(this.onCreatedContrat);
            contratListForm.SelectingContrat += new SelectingHandler(this.onSelectedContrat);
            
        }
        public CtrlListContrat(Collaborateur collaborateur, CollaborateurForm clf)
        {
            this.collaborateur = collaborateur;
            contratListForm = new ContratListForm(collaborateur);
            contratListForm.FormBorderStyle = FormBorderStyle.None;
            contratListForm.TopLevel = false;
            contratListForm.AutoScroll = true;
            clf.panelContrat.Controls.Add(contratListForm);
            contratListForm.Show();
            contratListForm.CloturingContrat += new EventHandler(onCloturedContrat);
            contratListForm.CreatingContrat += new EventHandler(this.onCreatedContrat);
            contratListForm.SelectingContrat += new SelectingHandler(this.onSelectedContrat);

        }
                

        public void init()
        {
            if (contratListForm != null)
            {
                contratListForm.ShowDialog();
            }
        }

        private void onSelectedContrat(int id)
        {
            Contrat contrat = getContrat(id);
            if (contrat != null)
            {
                CtrlViewContrat ctrlViewContrat = new CtrlViewContrat(contrat);
                ctrlViewContrat.CloturingContrat += new EventHandler(this.onCloturedContrat);
                ctrlViewContrat.Init();
            }
        }

        private Contrat getContrat(Int32 id)
        {
            Contrat contrat = null;
            foreach(Contrat c in collaborateur.Contrats)
            {
                if (c.Id == id)
                {
                    contrat = c;
                }
            }
            return contrat;
        }

        private void onCreatedContrat(object sender, EventArgs e)
        {
            CtrlNewContrat ctrlNewContrat = new CtrlNewContrat(ref collaborateur);
            ctrlNewContrat.SavingContrat += new EventHandler(this.onSavedContrat);
            ctrlNewContrat.init();
        }

        private void onSavedContrat(object sender, EventArgs e)
        { 
            refresh(sender, e);
        }

        private void onCloturedContrat(object sender, EventArgs e)
        {
            refresh(sender, e);
        }

        private void refresh(object sender, EventArgs e)
        {
            contratListForm.setDataSource();
            Refreshing?.Invoke(sender, e);
        }
    }
}
