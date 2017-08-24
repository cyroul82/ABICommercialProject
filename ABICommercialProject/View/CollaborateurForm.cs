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
        //public SavingCollaborateurEventHandler SavingCollaborateur;
        public selectCollaborateur collaboSelected;
        public CollaborateurForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Collaborateur collaborateur = getCollaborateur();
            if (collaborateur != null) {
                //SavingCollaborateur?.Invoke(c);
                DialogResult = DialogResult.OK;
                collaboSelected?.Invoke(collaborateur);
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

        private void cbxTypeContrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxTypeContrat.SelectedItem.ToString() == "CDD")
            {
                hideFields();
                txtMotif.Visible = true;
                lblMotif.Visible = true;
                lblDateFinContrat.Visible = true;
                dtpFinContrat.Visible = true;
            }
           else if (cbxTypeContrat.SelectedItem.ToString() == "CDI")
            {
                hideFields();
            }
            else if (cbxTypeContrat.SelectedItem.ToString() == "Stage")
            {
                hideFields();
                txtMotif.Visible = true;
                lblMotif.Visible = true;
                lblDateFinContrat.Visible = true;
                dtpFinContrat.Visible = true;
                lblEcole.Visible = true;
                txtEcole.Visible = true;
                lblMisson.Visible = true;
                txtMission.Visible = true;

            }
            else if (cbxTypeContrat.SelectedItem.ToString() == "Mission Intérim")
            {
                hideFields();
                txtMotif.Visible = true;
                lblMotif.Visible = true;
                lblDateFinContrat.Visible = true;
                dtpFinContrat.Visible = true;
                lblEcole.Visible = true;
                txtEcole.Visible = true;
                lblMisson.Visible = true;
                txtMission.Visible = true;
            }

        }

        private void hideFields()
        {
            txtMotif.Visible = false;
            lblMotif.Visible = false;
            txtEcole.Visible = false;
            lblEcole.Visible = false;
            txtMission.Visible = false;
            lblMisson.Visible = false;
            dtpFinContrat.Visible = false;
            lblDateFinContrat.Visible = false;
        }
    }
}
