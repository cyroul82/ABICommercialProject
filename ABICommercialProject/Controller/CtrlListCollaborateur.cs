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
    public delegate void SelectingHandler(Int32 id);
    public delegate void ContratHandler(Contrat contrat);
    public delegate void CollaboHandler(Collaborateur collaborateur);
    //public delegate void EventHandler(String message);

    public class CtrlListCollaborateur
    {
        public static SortedDictionary<Int32, Collaborateur> collaborateurList = new SortedDictionary<int, Collaborateur>();

        private CollaborateurListForm collaborateurListForm;

        private Collaborateur collaborateur;

        public CtrlListCollaborateur()
        {
            collaborateurListForm = new CollaborateurListForm(collaborateurList);
            collaborateurListForm.FormClosing += new FormClosingEventHandler(this.onClosedForm);
            collaborateurListForm.CreatingCollabo += new EventHandler(this.onCreatedCollabo);
            collaborateurListForm.SelectingCollabo += new SelectingHandler(this.onSelectedCollabo);
            collaborateurListForm.MdiParent = MainApp.getInstance();
            collaborateurListForm.Show();
        }

        private void onSelectedCollabo(Int32 id)
        {
            if (collaborateurList.ContainsKey(id))
            {
                Collaborateur collabo = collaborateurList[id];
                CtrlDetailCollaborateur ctrlDetailCollabo = new CtrlDetailCollaborateur(collabo);
                ctrlDetailCollabo.EditingCollaborateur += new CollaboHandler(this.editingCollabo);
                ctrlDetailCollabo.CloturingContrat += new ContratHandler(this.cloturingContrat);
                ctrlDetailCollabo.init();
            }
            else
            {
                MessageBox.Show("Cant't find the id ", "Error collabo matricule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cloturingContrat(Contrat contrat)
        {
            collaborateurListForm.setDataSource();
        }

        private void editingCollabo(Collaborateur collaborateur)
        {
            CtrlEditCollaborateur ctrlEditCollaborateur = new CtrlEditCollaborateur(collaborateur);
            ctrlEditCollaborateur.UpdatingCollabo += new CollaboHandler(this.onUpdatedCollabo);
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

        

        private void onCreatedCollabo(object sender, EventArgs e)
        {
            CtrlNewCollaborateur ctrlNewCollabo = new CtrlNewCollaborateur();
            ctrlNewCollabo.SavingCollaboData += new CollaboHandler(this.onSavedNewCollabo);
            ctrlNewCollabo.init();
        }

        private void onSavedNewCollabo(Collaborateur collabo)
        {
            collaborateurList.Add(collabo.Matricule, collabo);
            collaborateurListForm.setDataSource();
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
