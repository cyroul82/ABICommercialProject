using ABICommercialProject.Model;
using ABICommercialProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (!openedForm.ContainsKey(collaborateur.Matricule))
            {
                collaborateurForm = new CollaborateurForm(collaborateur, false);
                collaborateurForm.EditingCollabo += new CollaboHandler(this.onEditedCollabo);
                collaborateurForm.FormClosing += new FormClosingEventHandler(this.onClosedForm);
                collaborateurForm.ListContrat += new EventHandler(this.onListedContrat);
                collaborateurForm.Size = new System.Drawing.Size(950, 530);
                collaborateurForm.MdiParent = CtrlMain.getInstance().getMainApp();

                CtrlListContrat clc = new CtrlListContrat(collaborateur, collaborateurForm);
                clc.Refreshing += new EventHandler(this.onRefreshed);
                openedForm.Add(collaborateur.Matricule, collaborateurForm);
            }
            else
            {
                this.collaborateurForm = openedForm[collaborateur.Matricule];

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

        private void onListedContrat(object sender, EventArgs e)
        {
            
            CtrlListContrat ctrlListContrat = new CtrlListContrat(collaborateur);
            ctrlListContrat.Refreshing += new EventHandler(this.onRefreshed);
            ctrlListContrat.init();
        }

        private void onRefreshed(object sender, EventArgs e)
        {
            Refreshing?.Invoke(this, null);
        }

        public void init()
        {
            collaborateurForm.Show();
        }

        private void onClosedForm(object sender, FormClosingEventArgs e)
        {
            if (collaborateur != null)
            {
                openedForm.Remove(collaborateur.Matricule);
            }
        }

        private void onEditedCollabo(Collaborateur collabo)
        {
            if (collabo != null)
            {
                collaborateurForm.Close();
                EditingCollaborateur?.Invoke(collabo);
            }
        }
    }
}
