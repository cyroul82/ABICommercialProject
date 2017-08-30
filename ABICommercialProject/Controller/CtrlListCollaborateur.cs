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
    public class CtrlListCollaborateur
    {
        public static SortedDictionary<Int32, Collaborateur> collaborateurList = new SortedDictionary<int, Collaborateur>();

        private CollaborateurListForm collaborateurListForm;

        public CtrlListCollaborateur()
        {
            //Collaborateur c = new Collaborateur("RAT", "Cyril", "Concepteur");
            //c.Statut = true;
            //Cdi contrat = new Cdi("qualifié", DateTime.Now, Statut.Cadre, 1850);
            //Tools.collaborateurList.Add(564, c);

            collaborateurListForm = new CollaborateurListForm(collaborateurList);
            collaborateurListForm.FormClosing += new FormClosingEventHandler(this.collobarateurViewClosing);
            collaborateurListForm.onClickNewCollabo += new EventHandler(this.ajoutCollabo);
            collaborateurListForm.MdiParent = MainApp.getInstance();
            collaborateurListForm.Show();
        }

        private void ajoutCollabo(object sender, EventArgs e)
        {
            CtrlNewCollaborateur ctrlNewCollabo = new CtrlNewCollaborateur();
            ctrlNewCollabo.onSaveCollabo += new SaveCollaboHandler(this.saveCollabo);
        }

        private void saveCollabo(Collaborateur collabo)
        {
            collaborateurList.Add(564, collabo);
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
