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
        /// <summary>
        /// Constructor
        /// Instanciate the ContratListForm
        /// Listen to the event CloturingContrat, CreatingContrat and SelectingContrat of the ContratListForm
        /// </summary>
        /// <param name="collaborateur"></param>
        public CtrlListContrat(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            contratListForm = new ContratListForm(collaborateur);
            contratListForm.CloturingContrat += new EventHandler(OnCloturedContrat);
            contratListForm.CreatingContrat += new EventHandler(this.OnCreatedContrat);
            contratListForm.SelectingContrat += new SelectingHandler(this.OnSelectedContrat);

        }

        /// <summary>
        /// Return the ContratListForm
        /// </summary>
        /// <returns></returns>
        public ContratListForm GetContratListForm()
        {
            if (contratListForm != null)
            {
                return this.contratListForm;
            }
            else return null;
        }

        /// <summary>
        /// Method called when the event SelectingContrat is fired
        /// Instanciate the CtrlViewContat in order to visualize the detail of the selected Contrat 
        /// </summary>
        /// <param name="id"></param>
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

        /// <summary>
        /// Take an id Contrat as parameter/
        /// Look for the contract with the id Contrat in the collaboratuer's contract List 
        /// return the contract found or null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Method called when the event CreatingContrat is fired
        /// Instanciate the controller CtrlNewContrat in order to create a new contract
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCreatedContrat(object sender, EventArgs e)
        {
            CtrlNewContrat ctrlNewContrat = new CtrlNewContrat(collaborateur);
            ctrlNewContrat.SavingContrat += new EventHandler(this.OnSavedContrat);
            ctrlNewContrat.Init();
        }

        /// <summary>
        /// Method called when the event SavingContrat is fired
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSavedContrat(object sender, EventArgs e)
        { 
            Refresh(sender, e);
        }

        /// <summary>
        /// Method called when the event CloturingContrat is fired
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCloturedContrat(object sender, EventArgs e)
        {
            Refresh(sender, e);
        }

        /// <summary>
        /// Set the dataSource to the contratListForm when a changed occured
        /// invoke the 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Refresh(object sender, EventArgs e)
        {
            contratListForm.setDataSource();
            Refreshing?.Invoke(sender, e);
        }
    }
}
