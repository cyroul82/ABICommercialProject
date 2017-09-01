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
    public delegate void EditingCollaboHandler(Collaborateur collaborateur);
    public class CtrlDetailCollaborateur
    {
        private Collaborateur collaborateur;
        private CollaborateurForm collaborateurForm;
        private static SortedDictionary<Int32, CollaborateurForm> openedForm = new SortedDictionary<int, CollaborateurForm>();

        public EditingCollaboHandler EditingCollaborateur;
        
        public CtrlDetailCollaborateur(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            if (!openedForm.ContainsKey(collaborateur.Matricule))
            {
                this.collaborateurForm = new CollaborateurForm(collaborateur, false);
                collaborateurForm.SavingCollabo += new SavingCollaboHandler(this.onEditedCollabo);
                collaborateurForm.FormClosing += new FormClosingEventHandler(this.onClosedForm);
                collaborateurForm.CloturingContrat += new CloturingContratHandler(this.onCloturedContrat);
                collaborateurForm.MdiParent = MainApp.getInstance();

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

        public void init()
        {
            collaborateurForm.Show();
        }

        private void onCloturedContrat()
        {
            ClotureForm clotureForm = new ClotureForm(collaborateur.getContratActif());
            clotureForm.ShowDialog();
        }

        private void onClosedForm(object sender, FormClosingEventArgs e)
        {
            if (collaborateur != null)
            {
                openedForm.Remove(collaborateur.Matricule);
            }
        }

        private void onEditedCollabo(string message)
        {
            if (message == Tools.edit)
            {
                if (collaborateur != null)
                {
                    collaborateurForm.Close();
                    EditingCollaborateur?.Invoke(collaborateur);
                }
            }
        }
    }
}
