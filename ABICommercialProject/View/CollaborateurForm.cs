using ABICommercialProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABICommercialProject.View
{
    public delegate void SaveHandler(String message);
    public delegate void ClotureHandler();

    public partial class CollaborateurForm : Form
    {

        private Collaborateur collaborateur;

        public event SaveHandler onSaved;
        public event ClotureHandler onClotured;
        public CollaborateurForm()
        {
            InitializeComponent();
            init();
            setFormToNewCollabo();
        }

        public CollaborateurForm(Collaborateur collaborateur, Boolean edit)
        {
            InitializeComponent();
            this.collaborateur = collaborateur;
            init();

            setCollaborateur(collaborateur);
            if (edit)
            {
                setFormToEditCollabo();
            }
            else
            {
                setFormToDetailCollabo();
            }
        }

        public void init()
        {
            cbxStatut.DataSource = Enum.GetValues(typeof(Statut));
            cbxTypeContrat.DataSource = Enum.GetValues(typeof(TypeContrat));
        }

        private void setFormToNewCollabo()
        {
            collaborateur = null;
            setContratControlEnabled(false);
            setActionControlEnabled(false);
            setCollaborateurControlEnabled(false);
        }

        private void setFormToDetailCollabo()
        {
            setContratControlEnabled(true);
            setActionControlEnabled(false);
            setCollaborateurControlEnabled(true);
            btnSave.Text = Tools.edit;
        }

        private void setFormToEditCollabo()
        {
            setContratControlEnabled(true);
            setActionControlEnabled(true);
            setCollaborateurControlEnabled(false);
        }
        
        private void setContratControlEnabled(Boolean enable)
        {
            txtMotif.ReadOnly = enable;
            txtMission.ReadOnly = enable;
            txtEcole.ReadOnly = enable;
            txtSalaire.ReadOnly = enable;
            txtQualification.ReadOnly = enable;
            txtFonction.ReadOnly = enable;
            cbxStatut.Enabled = !enable;
            cbxTypeContrat.Enabled = !enable;
            dtpDebutContrat.Enabled = !enable;
            dtpFinContrat.Enabled = !enable;
        }

        private void setActionControlEnabled(Boolean enable)
        {
            btnAugmentation.Visible = enable;
            btnAvenant.Visible = enable;
            btnCloturer.Visible = enable;
        }

        private void setCollaborateurControlEnabled(Boolean enable)
        {
            txtNom.ReadOnly = enable;
            txtPrenom.ReadOnly = enable;
            txtEmail.ReadOnly = enable;
            txtCodePostal.ReadOnly = enable;
            txtAdresse.ReadOnly = enable;
            txtTel.ReadOnly = enable;
            txtVille.ReadOnly = enable;
        }

        private void setCollaborateur(Collaborateur collaborateur)
        {
            txtNom.Text = collaborateur.NomCollabo;
            txtPrenom.Text = collaborateur.PrenomCollabo;
            txtFonction.Text = collaborateur.FonctionCollabo;

            setContract();
        }

        private void setContract()
        {
            Contrat contrat = collaborateur.getContratActif();
            txtSalaire.Text = contrat.SalaireBrut.ToString();
            txtQualification.Text = contrat.Qualification;
            dtpDebutContrat.Text = contrat.DateDebutContrat.ToString();
            cbxStatut.SelectedItem = contrat.StatutContrat;

            if (contrat is ContratProvisoire)
            {
                ContratProvisoire contratProvisoire = contrat as ContratProvisoire;

                txtMotif.Text = contratProvisoire.Motif;
                dtpFinContrat.Text = contratProvisoire.DateFinContrat.ToString();

                if (contratProvisoire is Cdd)
                {
                    cbxTypeContrat.SelectedItem = TypeContrat.CDD;
                    Cdd cddContrat = collaborateur.getContratActif() as Cdd;

                    displayFormCdd();
                }
                
                if (contratProvisoire is Stage)
                {
                    cbxTypeContrat.SelectedItem = TypeContrat.Stage;
                    Stage stage = collaborateur.getContratActif() as Stage;
                    txtEcole.Text = stage.Ecole;
                    txtMission.Text = stage.Mission;

                    displayFormStage();
                }
                if (contratProvisoire is MissionInterim)
                {
                    cbxTypeContrat.SelectedItem = TypeContrat.Interim;
                    MissionInterim mission = collaborateur.getContratActif() as MissionInterim;
                    txtEcole.Text = mission.AgenceInterim;

                    displayFormInterim();
                }
            }
            if (contrat is Cdi)
            {
                cbxTypeContrat.SelectedItem = TypeContrat.CDI;
                displayFormCdi();
            }
        }

        private void displayFormCdd()
        {
            hideFields();
            txtMotif.Visible = true;
            lblMotif.Visible = true;
            lblDateFinContrat.Visible = true;
            dtpFinContrat.Visible = true;
        }


        private void displayFormCdi()
        {
            hideFields();
        }

        private void displayFormStage()
        {
            hideFields();
            txtMotif.Visible = true;
            lblMotif.Visible = true;
            lblDateFinContrat.Visible = true;
            dtpFinContrat.Visible = true;
            lblEcole.Text = "Ecole";
            lblEcole.Visible = true;
            txtEcole.Visible = true;
            lblMisson.Visible = true;
            txtMission.Visible = true;
        }

        public void displayFormInterim()
        {
            hideFields();
            txtMotif.Visible = true;
            lblMotif.Visible = true;
            lblDateFinContrat.Visible = true;
            dtpFinContrat.Visible = true;
            lblEcole.Text = "Agence";
            lblEcole.Visible = true;
            txtEcole.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void closeDialog()
        {
            this.DialogResult = DialogResult.OK;
        }

        public void displayDialog()
        {
            this.ShowDialog();
        }

        /// <summary>
        /// Get the the data from the textbox, create a collaborateur and return it
        /// </summary>
        /// <returns></returns>
        public Collaborateur getCollaborateur()
        {
            if (String.IsNullOrEmpty(txtNom.Text) || String.IsNullOrEmpty(txtPrenom.Text) || String.IsNullOrEmpty(txtFonction.Text))
            {
                return null;
            }
            else
            {
                String nom = txtNom.Text.Trim().ToUpper();
                String prenom = Tools.firstLetterUppercase(txtPrenom.Text.Trim());
                String fonction = Tools.firstLetterUppercase(txtFonction.Text.Trim());

                return new Collaborateur(nom, prenom, fonction, getContrat());
            }
        }

        private Contrat getContrat()
        {
            Contrat contrat;
            try
            {
                String typeContrat = cbxTypeContrat.SelectedItem.ToString();
                Statut statut = Tools.getStatut(cbxStatut.SelectedItem.ToString());
                DateTime debutContrat = Tools.getDate(dtpDebutContrat.Text);
                Decimal salaire = Tools.getSalaireBrut(txtSalaire.Text);
                String qualification = txtQualification.Text;

                if (typeContrat == TypeContrat.CDI.ToString())
                {
                    contrat = new Cdi(qualification, debutContrat, statut, salaire);
                    return contrat;
                }
                else
                {
                    DateTime finContrat = Tools.getDate(dtpFinContrat.Text);
                    String motif = txtMotif.Text;

                    if (typeContrat == TypeContrat.CDD.ToString())
                    {
                        contrat = new Cdd(motif, finContrat, qualification, debutContrat, statut, salaire);
                        return contrat;
                    }
                    else if (typeContrat == TypeContrat.Interim.ToString())
                    {
                        contrat = new MissionInterim(txtEcole.Text, motif, finContrat, qualification, debutContrat, statut, salaire);
                        return contrat;
                    }
                    else if (typeContrat == TypeContrat.Stage.ToString())
                    {
                        contrat = new Stage(txtEcole.Text, txtMission.Text, motif, finContrat, qualification, debutContrat, statut, salaire);
                        return contrat;
                    }
                    else
                    {
                        throw new Exception("Impossible to instanciate the contrat, no type defined");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creation contrat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        private void cbxTypeContrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxTypeContrat.SelectedItem.ToString() == TypeContrat.CDD.ToString())
            {
                displayFormCdd();
            }
            else if (cbxTypeContrat.SelectedItem.ToString() == TypeContrat.CDI.ToString())
            {
                displayFormCdi();
            }
            else if (cbxTypeContrat.SelectedItem.ToString() == TypeContrat.Stage.ToString())
            {
                displayFormStage();

            }
            else if (cbxTypeContrat.SelectedItem.ToString() == TypeContrat.Interim.ToString())
            {
                displayFormInterim();
            }
        }

        private void hideFields()
        {
            txtMotif.Visible = false;
            txtMotif.Text = "";
            lblMotif.Visible = false;
            txtEcole.Visible = false;
            txtEcole.Text = "";
            lblEcole.Visible = false;
            txtMission.Visible = false;
            txtMission.Text = "";
            lblMisson.Visible = false;
            dtpFinContrat.Visible = false;
            lblDateFinContrat.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkup())
            {
                if (btnSave.Text == Tools.save) onSaved(Tools.save);
                if (btnSave.Text == Tools.edit) onSaved(Tools.edit);
            }
        }

        public void displayErrorMessage(String message, String title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Boolean checkup()
        {
            Boolean checkPassed = true;
            //Decimal salaire;
            //if (Decimal.TryParse(txtSalaire.Text.Trim(), out salaire))
            //{
            //    if (salaire <= 0)
            //    {
            //        errorProviderSalaire.SetError(txtSalaire, "Requis");
            //        checkPassed = false;
            //        this.salaire = 0;
            //    }
            //    else
            //    {
            //        errorProviderSalaire.SetError(txtSalaire, String.Empty);
            //        this.salaire = salaire;
            //    }
            //}
            //else
            //{
            //    errorProviderSalaire.SetError(txtSalaire, "Requis");
            //    this.salaire = 0;
            //    checkPassed = false;
            //}

            //if (Tools.IsNameValid(txtQualification.Text))
            //{
            //    errorProviderQualification.SetError(txtQualification, String.Empty);
            //    this.qualification = txtQualification.Text.Trim(); ;
            //}
            //else
            //{
            //    errorProviderQualification.SetError(txtQualification, "Requis");
            //    this.qualification = null;
            //    checkPassed = false;
            //}

            //if (Tools.IsNameValid(txtFonction.Text))
            //{
            //    errorProviderFonction.SetError(txtFonction, String.Empty);
            //    this.fonction = txtFonction.Text.Trim();
            //}
            //else
            //{
            //    errorProviderFonction.SetError(txtFonction, "Requis");
            //    this.fonction = null;
            //    checkPassed = false;
            //}

            //if (Tools.IsNameValid(txtPrenom.Text))
            //{
            //    errorProviderPrenom.SetError(txtPrenom, String.Empty);
            //    this.prenom = txtPrenom.Text.Trim();
            //}
            //else
            //{
            //    errorProviderPrenom.SetError(txtPrenom, "Requis");
            //    this.prenom = null;
            //    checkPassed = false;
            //}

            //if (Tools.IsNameValid(txtNom.Text))
            //{
            //    errorProviderNom.SetError(txtNom, String.Empty);
            //    this.nom = txtNom.Text.Trim();
            //}
            //else
            //{
            //    errorProviderNom.SetError(txtNom, "Requis");
            //    this.nom = null;
            //    checkPassed = false;
            //}

            //if (Tools.IsNameValid(txtMotif.Text))
            //{
            //    errorProviderMotif.SetError(txtMotif, String.Empty);
            //    this.motif = txtMotif.Text.Trim();
            //}
            //else
            //{
            //    errorProviderMotif.SetError(txtMotif, "Requis");
            //    this.nom = null;
            //    checkPassed = false;
            //}

            //if (Tools.IsNameValid(txtMission.Text))
            //{
            //    errorProviderMission.SetError(txtMission, String.Empty);
            //    this.mission = txtMission.Text.Trim();
            //}
            //else
            //{
            //    errorProviderMission.SetError(txtMission, "Requis");
            //    this.nom = null;
            //    checkPassed = false;
            //}

            //if (Tools.IsNameValid(txtEcole.Text))
            //{
            //    errorProviderEcole.SetError(txtEcole, String.Empty);
            //    this.ecole = txtEcole.Text.Trim();
            //}
            //else
            //{
            //    errorProviderEcole.SetError(txtEcole, "Requis");
            //    this.nom = null;
            //    checkPassed = false;
            //}

            return checkPassed;
        }
        
        private void btnCloturer_Click(object sender, EventArgs e)
        {
            onClotured();
        }
    }
}
