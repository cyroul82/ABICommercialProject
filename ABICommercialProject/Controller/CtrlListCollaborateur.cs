using ABICommercialProject.Model;
using ABICommercialProject.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABICommercialProject.Controller
{
    public class CtrlListCollaborateur
    {
        public static SortedDictionary<Int32, Collaborateur> collaborateurList = new SortedDictionary<int, Collaborateur>();

        private CollaborateurListForm collaborateurListForm;

        public CtrlListCollaborateur()
        {
            Collaborateur c = new Collaborateur("RAT", "Cyril", "Concepteur");
            c.Matricule = 0;
            c.Statut = true;
            Cdi contrat = new Cdi("qualifié", DateTime.Now, Statut.Cadre, 1850);
            collaborateurList.Add(0, c);

            collaborateurListForm = new CollaborateurListForm(collaborateurList);
            collaborateurListForm.FormClosing += new FormClosingEventHandler(this.collobarateurViewClosing);
            collaborateurListForm.onClickNewCollabo += new EventHandler(this.newCollabo);
            collaborateurListForm.onSelectedCollabo += new SelectedColloboHandler(this.selectedCollabo);
            collaborateurListForm.MdiParent = MainApp.getInstance();
            collaborateurListForm.Show();
        }

        private void selectedCollabo(Int32 id)
        {
            if (collaborateurList.ContainsKey(id))
            {
                Collaborateur collabo = collaborateurList[id];
                CtrlDetailCollaborateur ctrlNewCollabo = new CtrlDetailCollaborateur(collabo);
            }
            else
            {
                MessageBox.Show("Cant't find the id ", "Error collabo matricule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void newCollabo(object sender, EventArgs e)
        {
            CtrlNewCollaborateur ctrlNewCollabo = new CtrlNewCollaborateur();
            ctrlNewCollabo.onSavedCollabo += new SavedCollaboHandler(this.saveCollabo);
        }

        private void saveCollabo(Collaborateur collabo)
        {
            Console.WriteLine("dans saveCollabo....");
        }

        private void collobarateurViewClosing(object sender, FormClosingEventArgs e)
        {
            collaborateurListForm = null;
            MainApp.getInstance().ctrlListCollaborateur = null;
        }

        public void display()
        {
            collaborateurListForm.display();
        }


    }
}
