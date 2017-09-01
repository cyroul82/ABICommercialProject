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
            collaborateurListForm = new CollaborateurListForm(collaborateurList);
            collaborateurListForm.FormClosing += new FormClosingEventHandler(this.onClosedForm);
            collaborateurListForm.CreatingCollabo += new CreatingCollaboHandler(this.onCreatedCollabo);
            collaborateurListForm.SelectingCollabo += new SelectingColloboHandler(this.onSelectedCollabo);
            collaborateurListForm.MdiParent = MainApp.getInstance();
            collaborateurListForm.Show();
        }

        private void onSelectedCollabo(Int32 id)
        {
            if (collaborateurList.ContainsKey(id))
            {
                Collaborateur collabo = collaborateurList[id];
                CtrlDetailCollaborateur ctrlDetailCollabo = new CtrlDetailCollaborateur(collabo);
                ctrlDetailCollabo.EditingCollaborateur += new EditingCollaboHandler(this.editingCollabo);
                ctrlDetailCollabo.init();
            }
            else
            {
                MessageBox.Show("Cant't find the id ", "Error collabo matricule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editingCollabo(Collaborateur collaborateur)
        {
            CtrlEditCollaborateur ctrlEditCollaborateur = new CtrlEditCollaborateur(collaborateur);
            ctrlEditCollaborateur.SavingCollabo += new SaveCollaboHandler(this.onUpdatedCollabo);
            ctrlEditCollaborateur.init();
        }

        private void onUpdatedCollabo(Collaborateur collabo)
        {
            if (collaborateurList.ContainsKey(collabo.Matricule))
            {
                collaborateurList[collabo.Matricule] = collabo;
                collaborateurListForm.setDataSource();
            }
            else
            {
                Console.WriteLine("Can't find the collabo in Memory to update it + " + collabo + " mat : " + collabo.Matricule );
            }
        }

        private void onSavedCollabo(Collaborateur collabo)
        {
            collaborateurList.Add(collabo.Matricule, collabo);
            collaborateurListForm.setDataSource();
        }

        private void onCreatedCollabo()
        {
            CtrlNewCollaborateur ctrlNewCollabo = new CtrlNewCollaborateur();
            ctrlNewCollabo.onSavedCollabo += new SaveCollaboHandler(this.onSavedCollabo);
            ctrlNewCollabo.init();
        }

        

        private void onClosedForm(object sender, FormClosingEventArgs e)
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
