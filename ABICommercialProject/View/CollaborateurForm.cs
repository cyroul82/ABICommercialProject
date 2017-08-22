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
    public partial class CollaborateurForm : Form
    {
        public SavingCollaborateurEventHandler SavingCollaborateur;
        public CollaborateurForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Collaborateur c = getCollaborateur();
            if (c != null) { 
            SavingCollaborateur?.Invoke(c);
            this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("All fields are required !", "Error Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private Collaborateur getCollaborateur()
        {
            if (String.IsNullOrEmpty(txtNom.Text) || String.IsNullOrEmpty(txtPrenom.Text) || String.IsNullOrEmpty(txtFonction.Text))
            {
                return null;
            }

            else
            {
                String nom = txtNom.Text.Trim().ToUpper();
                String prenom = firstLetterUppercase(txtNom.Text.Trim());
                String fonction = firstLetterUppercase(txtFonction.Text.Trim());

                return new Collaborateur(nom, prenom, fonction);
            }
        }

        private String firstLetterUppercase(String s)
        {
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }


    }
}
