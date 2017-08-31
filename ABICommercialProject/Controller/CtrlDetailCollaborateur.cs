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
        Collaborateur collaborateur;
        CollaborateurForm collaborateurForm;
        private static SortedDictionary<Int32, CollaborateurForm> openedForm = new SortedDictionary<int, CollaborateurForm>();

        public CtrlDetailCollaborateur(Collaborateur collaborateur)
        {
            
            this.collaborateur = collaborateur;
            if (!openedForm.ContainsKey(collaborateur.Matricule))
            {
                this.collaborateurForm = new CollaborateurForm(collaborateur, false);
                collaborateurForm.onSaved += new SaveHandler(this.clickEvent);
                collaborateurForm.FormClosing += new FormClosingEventHandler(this.closingForm);
                collaborateurForm.MdiParent = MainApp.getInstance();

                openedForm.Add(collaborateur.Matricule, collaborateurForm);

                collaborateurForm.Show();
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

        private void closingForm(object sender, FormClosingEventArgs e)
        {
            if (collaborateur != null)
            {
                openedForm.Remove(collaborateur.Matricule);
            }
        }

        private void clickEvent(string message)
        {
            if (message == Tools.edit)
            {
                collaborateurForm.Close();
                CtrlEditCollaborateur edit = new CtrlEditCollaborateur(collaborateur);

            }
        }
    }
}
