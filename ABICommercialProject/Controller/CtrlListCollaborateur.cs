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
        private CollaborateurListForm collaborateurListForm;

        public CtrlListCollaborateur()
        {
            //Collaborateur c = new Collaborateur("RAT", "Cyril", "Concepteur");
            //c.Statut = true;
            //Cdi contrat = new Cdi("qualifié", DateTime.Now, Statut.Cadre, 1850);
            //Tools.collaborateurList.Add(564, c);

            collaborateurListForm = new CollaborateurListForm(Tools.collaborateurList);

            IListerCollabo visu = (IListerCollabo)collaborateurListForm;
            visu.onAjoutCollabo += new ActionAjouterCollabo(this.ajoutCollabo);

            collaborateurListForm.FormClosing += new FormClosingEventHandler(this.collobarateurViewClosing);
            //collaborateurListForm.onAjoutCollabo += new ActionAjouterCollabo(this.ajoutCollabo);
            collaborateurListForm.MdiParent = MainApp.getInstance();
            collaborateurListForm.Show();
        }

        private void ajoutCollabo()
        {
            collaborateurListForm.AfficheCollabo();
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
