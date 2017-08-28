using ABICommercialProject.Controller;
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

    public partial class CollaborateurList : Form
    {
        private BindingSource bindingSourceCollabo;
        private Int32 selectedIndex;
        private DataTable dt;

        public CollaborateurList()
        {
            InitializeComponent();
            initializeDataTable();
            
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

        public DataTable getCollaborateurs()
        {
            if (dt != null)
            {
                foreach (KeyValuePair<Int32, Collaborateur> c in Collaborateur.collaborateurList)
                {
                    DataRow dr = dt.NewRow();
                    dr["Matricule"] = c.Value.Matricule;
                    dr["Nom"] = c.Value.NomCollabo;
                    dr["Prénom"] = c.Value.PrenomCollabo;
                    dr["Fonction"] = c.Value.FonctionCollabo;
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            else return null;
        }

        private void btnNewCollabo_Click(object sender, EventArgs e)
        {
            CollaborateurForm cv = new CollaborateurForm();
            cv.savingCollaborateur += new SavingCollaborateur(this.savingCollaborateur);
            if(cv.ShowDialog() == DialogResult.OK)
            {
                
            }
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
            Console.WriteLine(collaborateurDataGrid.CurrentRow.Cells[0].Value);
       }

        private void collaborateurDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            /*if(collaborateurDataGrid.SelectedRows.Count != 0)
                selectedIndex = collaborateurDataGrid.SelectedRows[0].Index;*/
        }
    }

}
