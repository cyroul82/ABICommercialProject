using ABIModel;
using ABIView;
using System;
using System.Windows.Forms;

namespace ABIController
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
            
        }

        public ContratListForm GetContratListForm()
        {
            if (contratListForm != null)
            {
                return this.contratListForm;
            }
            else return null;
        }

                

        public void Init()
        {
            if (contratListForm != null)
            {
                contratListForm.CloturingContrat += new EventHandler(OnCloturedContrat);
                contratListForm.CreatingContrat += new EventHandler(this.OnCreatedContrat);
                contratListForm.SelectingContrat += new SelectingHandler(this.OnSelectedContrat);
            }
        }

        private void OnSelectedContrat(int id)
        {
            Contrat contrat = GetContrat(id);
            if (contrat != null)
            {
                CtrlViewContrat ctrlViewContrat = new CtrlViewContrat(contrat);
                ctrlViewContrat.CloturingContrat += new EventHandler(this.OnCloturedContrat);
                ctrlViewContrat.Init();
            }
        }

        private Contrat GetContrat(Int32 id)
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

        private void OnCreatedContrat(object sender, EventArgs e)
        {
            CtrlNewContrat ctrlNewContrat = new CtrlNewContrat(collaborateur);
            ctrlNewContrat.SavingContrat += new EventHandler(this.OnSavedContrat);
            ctrlNewContrat.Init();
        }

        private void OnSavedContrat(object sender, EventArgs e)
        { 
            Refresh(sender, e);
        }

        private void OnCloturedContrat(object sender, EventArgs e)
        {
            Refresh(sender, e);
        }

        private void Refresh(object sender, EventArgs e)
        {
            contratListForm.setDataSource();
            Refreshing?.Invoke(sender, e);
        }
    }
}
