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

    public class CtrlListCollaborateur
    {

        private CollaborateurListForm collaborateurListForm;
        private SortedDictionary<Int32, Collaborateur> collaborateurList;
        public CtrlListCollaborateur()
        {
            try
            {
                
                    collaborateurList = DAOToChange.getInstance().getCollaborateurList();
                    init();
                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + " " + e.StackTrace);
            }
        }

        private void init()
        {
            collaborateurListForm = new CollaborateurListForm(collaborateurList);
            collaborateurListForm.FormClosing += new FormClosingEventHandler(this.onClosedForm);
            collaborateurListForm.CreatingCollabo += new EventHandler(this.onCreatedCollabo);
            collaborateurListForm.SelectingCollabo += new SelectingHandler(this.onSelectedCollabo);
            collaborateurListForm.MdiParent = CtrlMain.getInstance().getMainApp();
            collaborateurListForm.Show();
        }

        private void onSelectedCollabo(Int32 id)
        {
            if (collaborateurList.ContainsKey(id))
            {
                Collaborateur collabo = collaborateurList[id];
                CtrlDetailCollaborateur ctrlDetailCollabo = new CtrlDetailCollaborateur(collabo);
                ctrlDetailCollabo.EditingCollaborateur += new CollaboHandler(this.onEditedCollabo);
                ctrlDetailCollabo.Refreshing += new EventHandler(this.onRefreshed);
                ctrlDetailCollabo.init();
            }
            else
            {
                MessageBox.Show("Cant't find the id ", "Error collabo matricule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void onRefreshed(object sender, EventArgs e)
        {
            collaborateurListForm.setDataSource();
        }

        private void onEditedCollabo(Collaborateur collaborateur)
        {
            CtrlEditCollaborateur ctrlEditCollaborateur = new CtrlEditCollaborateur(collaborateur);
            ctrlEditCollaborateur.UpdatingCollabo += new CollaboHandler(this.onUpdatedCollabo);
            ctrlEditCollaborateur.init();
        }

        private void onUpdatedCollabo(Collaborateur collabo)
        {
            if (collaborateurList.ContainsKey(collabo.Id))
            {
                collaborateurList[collabo.Id] = collabo;
                collaborateurListForm.setDataSource();
            }
            else
            {
                Console.WriteLine("Can't find the collabo in Memory to update it + " + collabo + " mat : " + collabo.Id);
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
            collaborateurList.Add(collabo.Id, collabo);
            collaborateurListForm.setDataSource();
        }


        private void onClosedForm(object sender, FormClosingEventArgs e)
        {

            collaborateurListForm = null;
            CtrlMain.getInstance().closeCtrlListCollaborateur(); ;
        }

        public void display()
        {
            collaborateurListForm.display();
        }


    }
}
