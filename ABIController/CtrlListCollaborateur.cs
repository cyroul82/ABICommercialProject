using ABIDAO;
using ABIModel;
using ABIView;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIController
{
    

    public class CtrlListCollaborateur
    {

        private CollaborateurListForm collaborateurListForm;
        private SortedDictionary<Int32, Collaborateur> collaborateurList;
        public CtrlListCollaborateur()
        {
            try
            {
                collaborateurList = DAOToChange.getInstance().getCollaborateurList();
                Init();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + " " + e.StackTrace);
            }
        }

        private void Init()
        {
            collaborateurListForm = new CollaborateurListForm(collaborateurList);
            collaborateurListForm.FormClosing += new FormClosingEventHandler(this.OnClosedForm);
            collaborateurListForm.CreatingCollabo += new EventHandler(this.OnCreatedCollabo);
            collaborateurListForm.SelectingCollabo += new SelectingHandler(this.OnSelectedCollabo);
            collaborateurListForm.MdiParent = CtrlMain.getInstance().getMainApp();
            collaborateurListForm.Show();
        }

        public void RefreshList()
        {
            if(collaborateurListForm != null)
            {
                collaborateurListForm.refreshList(collaborateurList);
            }
        }


        private void OnSelectedCollabo(Int32 id)
        {
            if (collaborateurList.ContainsKey(id))
            {
                Collaborateur collabo = collaborateurList[id];
                CtrlDetailCollaborateur ctrlDetailCollabo = new CtrlDetailCollaborateur(collabo);
                ctrlDetailCollabo.EditingCollaborateur += new CollaboHandler(this.OnEditedCollabo);
                ctrlDetailCollabo.Refreshing += new EventHandler(this.OnRefreshed);
                ctrlDetailCollabo.Init();
            }
            else
            {
                MessageBox.Show("Cant't find the id ", "Error collabo matricule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OnRefreshed(object sender, EventArgs e)
        {
            collaborateurListForm.setDataSource();
        }

        private void OnEditedCollabo(Collaborateur collaborateur)
        {
            CtrlEditCollaborateur ctrlEditCollaborateur = new CtrlEditCollaborateur(collaborateur);
            ctrlEditCollaborateur.UpdatingCollabo += new CollaboHandler(this.OnUpdatedCollabo);
            ctrlEditCollaborateur.Init();
        }

        private void OnUpdatedCollabo(Collaborateur collabo)
        {
            if (collaborateurList.ContainsKey(collabo.Id))
            {
                collaborateurListForm.setDataSource();
            }
        }

        private void OnCreatedCollabo(object sender, EventArgs e)
        {
            CtrlNewCollaborateur ctrlNewCollabo = new CtrlNewCollaborateur();
            ctrlNewCollabo.SavingCollaboData += new CollaboHandler(this.OnSavedNewCollabo);
            ctrlNewCollabo.init();
        }

        private void OnSavedNewCollabo(Collaborateur collabo)
        {
            collaborateurList.Add(collabo.Id, collabo);
            collaborateurListForm.setDataSource();
        }


        private void OnClosedForm(object sender, FormClosingEventArgs e)
        {
            collaborateurListForm = null;
            CtrlMain.getInstance().closeCtrlListCollaborateur(); ;
        }

        public void Display()
        {
            collaborateurListForm.display();
        }


    }
}
