using ABIModel;
using ABIView;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABIController
{
    public class CtrlDetailCollaborateur
    {
        private Collaborateur collaborateur;
        private CollaborateurForm collaborateurForm;
        private static SortedDictionary<Int32, CollaborateurForm> openedFormList = new SortedDictionary<int, CollaborateurForm>();

        public CollaboHandler EditingCollaborateur;
        public CollaboHandler UpdatinCollabo;
        public EventHandler Refreshing;
        
        /// <summary>
        /// Constructor
        /// Takes a collaborateur as argument
        /// initialize a new instanciate of the class CollaborateurForm
        /// Listen to the event EditingCollabo and FormClosing  of the collaborateurForm
        /// instanciate the CtrlListContrat
        /// </summary>
        /// <param name="collaborateur"></param>
        public CtrlDetailCollaborateur(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            if (!openedFormList.ContainsKey(collaborateur.Id))
            {
                collaborateurForm = new CollaborateurForm(false);
                collaborateurForm.SetCollaborateur(collaborateur);
                collaborateurForm.EditingCollabo += new CollaboHandler(this.OnEditedCollabo);
                collaborateurForm.FormClosing += new FormClosingEventHandler(this.OnClosedForm);
                collaborateurForm.Size = new System.Drawing.Size(950, 530);
                collaborateurForm.MdiParent = CtrlMain.GetInstance().GetMainApp();

                CtrlListContrat clc = new CtrlListContrat(collaborateur);
                clc.Refreshing += new EventHandler(this.OnRefreshed);
                clc.UpdatinCollabo += new CollaboHandler(this.OnUpdatedCollabo);

                ContratListForm contratListForm = clc.GetContratListForm();
                contratListForm.FormBorderStyle = FormBorderStyle.None;
                contratListForm.TopLevel = false;
                contratListForm.AutoScroll = true;
                contratListForm.Show();
                

                collaborateurForm.panelContrat.Controls.Add(contratListForm);
                openedFormList.Add(collaborateur.Id, collaborateurForm);
            }
            else
            {
                this.collaborateurForm = openedFormList[collaborateur.Id];

                if (collaborateurForm.WindowState == FormWindowState.Minimized)
                {
                    collaborateurForm.WindowState = FormWindowState.Normal;
                }
                else
                {
                    collaborateurForm.Activate();
                }
            }
        }

        private void OnUpdatedCollabo(Collaborateur collaborateur)
        {
            UpdatinCollabo?.Invoke(collaborateur);
           // Refreshing?.Invoke(this, null);
        }

        /// <summary>
        /// Raise the refreshing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRefreshed(object sender, EventArgs e)
        {
            Refreshing?.Invoke(this, null);
        }

        /// <summary>
        /// Displazy the form
        /// </summary>
        public void Display()
        {
            collaborateurForm.Show();
        }

        /// <summary>
        /// Close the Form
        /// Remove the instance of the Form from the openedFormList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClosedForm(object sender, FormClosingEventArgs e)
        {
            if (collaborateur != null)
            {
                openedFormList.Remove(collaborateur.Id);
            }
        }

        /// <summary>
        /// Close the collaborateurFrom 
        /// Raise the EditingCollaborateur event
        /// </summary>
        /// <param name="collabo"></param>
        private void OnEditedCollabo(Collaborateur collabo)
        {
            if (collabo != null)
            {
                collaborateurForm.Close();
                EditingCollaborateur?.Invoke(collabo);
            }
        }
    }
}
