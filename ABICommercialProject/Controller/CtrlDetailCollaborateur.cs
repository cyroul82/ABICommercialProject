using ABICommercialProject.View;
using ABIModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABICommercialProject.Controller
{
    public class CtrlDetailCollaborateur
    {
        private Collaborateur collaborateur;
        private CollaborateurForm collaborateurForm;
        private static SortedDictionary<Int32, CollaborateurForm> openedForm = new SortedDictionary<int, CollaborateurForm>();

        public CollaboHandler EditingCollaborateur;
        public EventHandler Refreshing;
        
        public CtrlDetailCollaborateur(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            if (!openedForm.ContainsKey(collaborateur.Id))
            {
                collaborateurForm = new CollaborateurForm(false);
                collaborateurForm.SetCollaborateur(collaborateur);
                collaborateurForm.EditingCollabo += new CollaboHandler(this.OnEditedCollabo);
                collaborateurForm.FormClosing += new FormClosingEventHandler(this.OnClosedForm);
                collaborateurForm.ListContrat += new EventHandler(this.OnListedContrat);
                collaborateurForm.Size = new System.Drawing.Size(950, 530);
                collaborateurForm.MdiParent = CtrlMain.getInstance().getMainApp();

                CtrlListContrat clc = new CtrlListContrat(collaborateur, collaborateurForm);
                clc.Refreshing += new EventHandler(this.OnRefreshed);
                openedForm.Add(collaborateur.Id, collaborateurForm);
            }
            else
            {
                this.collaborateurForm = openedForm[collaborateur.Id];

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

        private void OnListedContrat(object sender, EventArgs e)
        {
            
            CtrlListContrat ctrlListContrat = new CtrlListContrat(collaborateur);
            ctrlListContrat.Refreshing += new EventHandler(this.OnRefreshed);
            ctrlListContrat.init();
        }

        private void OnRefreshed(object sender, EventArgs e)
        {
            Refreshing?.Invoke(this, null);
        }

        public void Init()
        {
            collaborateurForm.Show();
        }

        private void OnClosedForm(object sender, FormClosingEventArgs e)
        {
            if (collaborateur != null)
            {
                openedForm.Remove(collaborateur.Id);
            }
        }

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
