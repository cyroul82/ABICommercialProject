using ABIDAO;
using ABIModel;
using ABIView;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABIController
{
    public class CtrlListCollaborateur
    {

        private CollaborateurListForm collaborateurListForm;
        private SortedDictionary<Int32, Collaborateur> collaborateurList;

        /// <summary>
        /// Constructor 
        /// Get the collaborateur list from the DAO
        /// </summary>
        /// <exception cref="Exception">Can't get the collaborateur collection</exception>
        public CtrlListCollaborateur()
        {
            try
            {
                collaborateurList = DAO.getInstance().getCollaborateurList();
                Init();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + " " + e.StackTrace);
            }
        }

        /// <summary>
        /// Initialise une nouvelle Instance du form CollaborateurListForm
        /// S'abonne aux événements FormClosing, CreatingCollabo and SelectingCollabo
        /// Affiche le form
        /// </summary>
        private void Init()
        {
            collaborateurListForm = new CollaborateurListForm(collaborateurList);
            collaborateurListForm.FormClosing += new FormClosingEventHandler(this.OnClosedForm);
            collaborateurListForm.CreatingCollabo += new EventHandler(this.OnCreatedCollabo);
            collaborateurListForm.SelectingCollabo += new SelectingHandler(this.OnSelectedCollabo);
            collaborateurListForm.MdiParent = CtrlMain.GetInstance().GetMainApp();
            collaborateurListForm.Show();
        }

        /// <summary>
        /// Method called whenever the event SelectingCollabo is fired
        /// check that the id exists in the Collaborateur Collection
        /// instanciate athe controller CtrlDetailCollaborateur
        /// Listen to the event EditingCollaborateur
        /// Listen to the event Refreshing
        /// </summary>
        /// <param name="id"></param>
        private void OnSelectedCollabo(Int32 id)
        {
            if (collaborateurList.ContainsKey(id))
            {
                Collaborateur collabo = collaborateurList[id];
                CtrlDetailCollaborateur ctrlDetailCollabo = new CtrlDetailCollaborateur(collabo);
                ctrlDetailCollabo.EditingCollaborateur += new CollaboHandler(this.OnEditedCollabo);
                ctrlDetailCollabo.Refreshing += new EventHandler(this.OnRefreshed);
                ctrlDetailCollabo.UpdatinCollabo += new CollaboHandler(this.OnUpdatedCollabo);
                ctrlDetailCollabo.Display();
            }
            else
            {
                MessageBox.Show("Cant't find the id ", "Error collabo matricule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Refresh the DataGridView
        /// set the DataGridView's DataSource in the form collaborateurListForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRefreshed(object sender, EventArgs e)
        {
            RefreshDataSource();
        }

        /// <summary>
        /// Call when the event EditingCollabo is fired
        /// Instanciate the controller CtrlEditCollaborateur
        /// </summary>
        /// <param name="collaborateur"></param>
        private void OnEditedCollabo(Collaborateur collaborateur)
        {
            CtrlEditCollaborateur ctrlEditCollaborateur = new CtrlEditCollaborateur(collaborateur);
            ctrlEditCollaborateur.UpdatingCollabo += new CollaboHandler(this.OnUpdatedCollabo);
            ctrlEditCollaborateur.Init();
        }

        /// <summary>
        /// Method call when the event UpdatingCollabo is fired
        /// Check that the collabo exists in the collabo
        /// refresh the DataGridView of the form
        /// </summary>
        /// <param name="collabo"></param>
        private void OnUpdatedCollabo(Collaborateur collabo)
        {
            if (collaborateurList.ContainsKey(collabo.Id))
            {
                DAO.getInstance().UpdateCollorateur();
                RefreshDataSource();   
            }
        }

        /// <summary>
        /// Refresh the datagridview in the form
        /// </summary>
        private void RefreshDataSource()
        {
            collaborateurListForm.SetDataSource();
        }

        /// <summary>
        /// Method called when the event CreatingCollabo is fired
        /// initialize a new instanciate of the class CtrlNewCollaborateur
        /// Listen to the event SavingCollaboData
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCreatedCollabo(object sender, EventArgs e)
        {
            CtrlNewCollaborateur ctrlNewCollabo = new CtrlNewCollaborateur();
            ctrlNewCollabo.SavingCollabo += new CollaboHandler(this.OnSavedNewCollabo);
            ctrlNewCollabo.DisplayForm();
        }

        /// <summary>
        /// Method called when the event SavingCollaboData is fired
        /// Add a new collaborateur the the collection and set the DataGridView's DataSource in the form collaborateurListForm
        /// </summary>
        /// <param name="collabo"></param>
        private void OnSavedNewCollabo(Collaborateur collabo)
        {
            try
            {
                DAO.getInstance().NewCollaborateur(collabo);
                collaborateurList.Add(collabo.Id, collabo);
                RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error New Collaborateur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Method called when the event FormClosing is called
        /// set the collaborateurListForm to null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClosedForm(object sender, FormClosingEventArgs e)
        {
            collaborateurListForm = null;
            CtrlMain.GetInstance().CloseCtrlListCollaborateur(); ;
        }

        /// <summary>
        /// Call the method display of the form to display it
        /// </summary>
        public void Display()
        {
            collaborateurListForm.Display();
        }


    }
}
