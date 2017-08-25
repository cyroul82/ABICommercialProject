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
    public partial class CollaborateurForm : Form
    {
        public SavingCollaborateur savingCollaborateur;

        private String nom;
        private String prenom;
        private String fonction;
        private String qualification;
        private String motif;
        private Decimal salaire = 0;

        public CollaborateurForm()
        {
            InitializeComponent();
            cbxStatut.DataSource = Enum.GetValues(typeof(Statut));
            cbxTypeContrat.DataSource = Enum.GetValues(typeof(TypeContrat));
            hideFields();
            btnSave.Enabled = false;
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

        private Contrat getContrat()
        {
            return new Cdi("prof", DateTime.Now, Statut.Technicien, 1850);
        }

        private String firstLetterUppercase(String s)
        {
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        private void cbxTypeContrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxTypeContrat.SelectedItem.ToString() == TypeContrat.CDD.ToString())
            {
                hideFields();
                txtMotif.Visible = true;
                lblMotif.Visible = true;
                lblDateFinContrat.Visible = true;
                dtpFinContrat.Visible = true;
            }
           else if (cbxTypeContrat.SelectedItem.ToString() == TypeContrat.CDI.ToString())
            {
                hideFields();
            }
            else if (cbxTypeContrat.SelectedItem.ToString() == TypeContrat.Stage.ToString())
            {
                hideFields();
                txtMotif.Visible = true;
                lblMotif.Visible = true;
                lblDateFinContrat.Visible = true;
                dtpFinContrat.Visible = true;
                lblEcole.Text = "Ecole";
                lblEcole.Visible = true;
                txtName.Visible = true;
                lblMisson.Visible = true;
                txtMission.Visible = true;

            }
            else if (cbxTypeContrat.SelectedItem.ToString() == TypeContrat.Interim.ToString())
            {
                hideFields();
                txtMotif.Visible = true;
                lblMotif.Visible = true;
                lblDateFinContrat.Visible = true;
                dtpFinContrat.Visible = true;
                lblEcole.Text = "Agence";
                lblEcole.Visible = true;
                txtName.Visible = true;
            }
        }

        private void hideFields()
        {
            txtMotif.Visible = false;
            lblMotif.Visible = false;
            txtName.Visible = false;
            lblEcole.Visible = false;
            txtMission.Visible = false;
            lblMisson.Visible = false;
            dtpFinContrat.Visible = false;
            lblDateFinContrat.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            savingCollaborateur(getCollaborateur(), getContrat());
            DialogResult = DialogResult.OK;
        }

        private void txtMotif_Validated(object sender, EventArgs e)
        {
            if (Tools.IsNameValid(txtMotif.Text))
            {
                errorProviderMotif.SetError(txtMotif, String.Empty);
                this.motif = txtMotif.Text;
            }
            else
            {
                errorProviderMotif.SetError(txtMotif, "Requis");
                this.motif = null;
            }
        }

        private void isFormReady()
        {
            Boolean ready;
            if (String.IsNullOrEmpty(nom) || String.IsNullOrEmpty(prenom) || String.IsNullOrEmpty(fonction)
                 || String.IsNullOrEmpty(qualification) || salaire == 0)
            {
                ready = false;
            }
            else ready = true;
            btnSave.Enabled = ready;
        }


        private void txtSalaire_KeyUp(object sender, KeyEventArgs e)
        {
            Decimal salaire;
            if (Decimal.TryParse(txtSalaire.Text.Trim(), out salaire))
            {
                if (salaire <= 0)
                {
                    errorProviderSalaire.SetError(txtSalaire, "Requis");
                    this.salaire = 0;
                }
                else
                {
                    errorProviderSalaire.SetError(txtSalaire, String.Empty);
                    this.salaire = salaire;
                }
            }
            else
            {
                errorProviderSalaire.SetError(txtSalaire, "Requis");
                this.salaire = 0;
            }
            isFormReady();
        }

        private void txtQualification_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tools.IsNameValid(txtQualification.Text))
            {
                errorProviderQualification.SetError(txtQualification, String.Empty);
                this.qualification = txtQualification.Text.Trim(); ;
            }
            else
            {
                errorProviderQualification.SetError(txtQualification, "Requis");
                this.qualification = null;
            }
            isFormReady();
        }

        private void txtFonction_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tools.IsNameValid(txtFonction.Text))
            {
                errorProviderFonction.SetError(txtFonction, String.Empty);
                this.fonction = txtFonction.Text.Trim();
            }
            else
            {
                errorProviderFonction.SetError(txtFonction, "Requis");
                this.fonction = null;
            }
            isFormReady();
        }

        private void txtPrenom_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tools.IsNameValid(txtPrenom.Text))
            {
                errorProviderPrenom.SetError(txtPrenom, String.Empty);
                this.prenom = txtPrenom.Text.Trim();
            }
            else
            {
                errorProviderPrenom.SetError(txtPrenom, "Requis");
                this.prenom = null;
            }
            isFormReady();
        }

        private void txtNom_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tools.IsNameValid(txtNom.Text))
            {
                errorProviderNom.SetError(txtNom, String.Empty);
                this.nom = txtNom.Text.Trim();
            }
            else
            {
                errorProviderNom.SetError(txtNom, "Requis");
                this.nom = null;
            }
            isFormReady();
        }
    }
}
