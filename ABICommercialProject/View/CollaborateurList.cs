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
        private CollaborateurController cc;
        private BindingSource bindingSourceCollabo;
        private Int32 selectedIndex;

        public CollaborateurList()
        {
            InitializeComponent();
            cc = new CollaborateurController();
            bindingSourceCollabo = new BindingSource();
            bindingSourceCollabo.DataSource = cc.getCollaborateurs();
            collaborateurDataGrid.DataSource = bindingSourceCollabo;
        }

        private void btnNewCollabo_Click(object sender, EventArgs e)
        {
            CollaborateurForm cv = new CollaborateurForm();
            cv.savingCollaborateur += new SavingCollaborateur(this.savingCollaborateur);
            if(cv.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void savingCollaborateur(Collaborateur collaborateur, Contrat contrat)
        {
            cc.saveCollaborateur(collaborateur, contrat);
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
