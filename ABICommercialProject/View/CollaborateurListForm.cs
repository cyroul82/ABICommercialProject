using ABICommercialProject.Controller;
using ABICommercialProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABICommercialProject.View
{

    public partial class CollaborateurListForm : Form, IListerCollabo
    {
        private BindingSource bindingSourceCollabo;
        private Collaborateur selectedCollaborateur;
        private DataTable dt;
        private SortedDictionary<Int32, Collaborateur> collaborateurList;

        public event ActionAjouterCollabo onAjoutCollabo;

        public Collaborateur collaboActif
        {
            get
            {
               return selectedCollaborateur;
            }
        }

        public CollaborateurListForm(SortedDictionary<Int32, Collaborateur> collaborateurList)
        {
            InitializeComponent();
            this.collaborateurList = collaborateurList;
            initializeDataTable();
            selectedCollaborateur = null;
            
        }

        private void initializeDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Matricule");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Prénom");
            dt.Columns.Add("Fonction");

            bindingSourceCollabo = new BindingSource();
            bindingSourceCollabo.DataSource = getCollaborateurs();
            collaborateurDataGrid.DataSource = bindingSourceCollabo;
        }

        public void display()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.Activate();
            }
        }

        public DataTable getCollaborateurs()
        {
            if (dt != null)
            {
                foreach (KeyValuePair<Int32, Collaborateur> c in collaborateurList)
                {
                    if (c.Value.Statut)
                    {
                        DataRow dr = dt.NewRow();
                        dr["Matricule"] = c.Value.Matricule;
                        dr["Nom"] = c.Value.NomCollabo;
                        dr["Prénom"] = c.Value.PrenomCollabo;
                        dr["Fonction"] = c.Value.FonctionCollabo;
                        dt.Rows.Add(dr);
                        Console.WriteLine(c.Value.NomCollabo);
                    }
                    else
                    {

                    }

                }
                return dt;
            }
            else return null;
        }

        private void btnNewCollabo_Click(object sender, EventArgs e)
        {
            CtrlNewCollaborateur ctrl = new CtrlNewCollaborateur();
        }

        private void addCollaborateur(Collaborateur collaborateur)
        {
            DataRow dr = dt.NewRow();
            dr["Matricule"] = collaborateur.Matricule;
            dr["Nom"] = collaborateur.NomCollabo;
            dr["Prénom"] = collaborateur.PrenomCollabo;
            dr["Fonction"] = collaborateur.FonctionCollabo;
            dt.Rows.Add(dr);
        }

        private void savingCollaborateur(Collaborateur collaborateur, Contrat contrat)
        {
            addCollaborateur(collaborateur);
        }

        private void collaborateurDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            //if (collaborateurDataGrid.SelectedRows.Count > 0 &&
            //    collaborateurDataGrid.SelectedRows[0].Index != collaborateurDataGrid.Rows.Count - 1)
            //{

            //}
            //if(collaborateurDataGrid.RowCount > 0)
            //{
            //    selectedCollaborateur = CollaborateurController.getCollaboInstance().getCollaborateur(Convert.ToInt32(collaborateurDataGrid.CurrentRow.Cells[0].Value));
            //    btnCloture.Enabled = true;
            //    Console.WriteLine(selectedCollaborateur);
            //}
       }

        private void collaborateurDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (collaborateurDataGrid.SelectedRows.Count != 0)
            {
                selectedCollaborateur = null;
                
            }
            else
            {
                selectedCollaborateur = null;
            }
        }

        private void btnCloture_Click(object sender, EventArgs e)
        {
            //CollaborateurController.getCollaboInstance().clotureContratCollaborateur(selectedCollaborateur);
        }

        public void AfficheCollabo(Collaborateur collabo)
        {
            throw new NotImplementedException();
        }
    }

}
