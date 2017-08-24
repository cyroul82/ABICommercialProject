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
        CollaborateurController cc;
        private BindingSource bindingSourceCollabo;

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
            cc.saveCollaborateur(collaborateur);
        }
    }

}
