using ABICommercialProject.Controller;
using ABIModel;
using System;
using System.Windows.Forms;

namespace ABICommercialProject.View
{
    public partial class ContratForm : Form
    {
        private Contrat contrat;

        public ContratHandler SavingContrat;
        public event EventHandler CloturingContrat;
        public ContratForm()
        {
            InitializeComponent();
            Init();
            ControlEnabled(true);

        }
        public ContratForm(Contrat contrat)
        {
            InitializeComponent();
            Init();
            this.contrat = contrat;
            this.setContract();
            this.Text = "Contrat : " + contrat.Id;
            ControlEnabled(false);
            if (contrat.Cloture)
            {
                HideControl();
            }
        }

        private void Init()
        {
            cbxStatut.DataSource = Enum.GetValues(typeof(Statut));
            cbxTypeContrat.DataSource = Enum.GetValues(typeof(TypeContrat));
            cbxTypeContrat.SelectedItem = TypeContrat.CDI.ToString();
        }



        /// <summary>
        /// Disable or Activate the form control
        /// <para>false -> disable</para>
        /// <para>true -> enable</para>
        /// </summary>
        /// <param name="enable"></param>
        private void ControlEnabled(Boolean enable)
        {
            cbxTypeContrat.Enabled = enable;
            txtQualification.ReadOnly = !enable;
            cbxStatut.Enabled = enable;
            txtSalaire.ReadOnly = !enable;
            dtpDebutContrat.Enabled = enable;
            dtpFinContrat.Enabled = enable;
            txtMotif.ReadOnly = !enable;
            txtEcole.ReadOnly = !enable;
            txtMission.ReadOnly = !enable;
            btnSave.Enabled = enable;
            btnCloturer.Visible = !enable;
            btnSave.Visible = enable;
            btnAvenant.Visible = !enable;

        }

        /// <summary>
        /// Hide button Cloturer, Save and Cancel
        /// </summary>
        private void HideControl()
        {
            btnCloturer.Visible = false;
            btnSave.Visible = false;
            btnAvenant.Visible = false;
            btnCancel.Text = "Fermer";
        }

        /// <summary>
        /// Fills up the textboxes
        /// </summary>
        private void setContract()
        {
            
                btnSave.Enabled = false;
                txtSalaire.Text = contrat.SalaireBrut.ToString();
                txtQualification.Text = contrat.Qualification;
                dtpDebutContrat.Text = contrat.DateDebutContrat.Date.ToShortDateString();
                cbxStatut.SelectedItem = contrat.StatutContrat;

                if (contrat is ContratProvisoire)
                {
                    ContratProvisoire contratProvisoire = contrat as ContratProvisoire;

                    txtMotif.Text = contratProvisoire.Motif;
                    dtpFinContrat.Text = contratProvisoire.DateFinContrat.ToString();

                    if (contratProvisoire is Cdd)
                    {
                        cbxTypeContrat.SelectedItem = TypeContrat.CDD;
                        Cdd cddContrat = contrat as Cdd;

                        DisplayFormCdd();
                    }

                    if (contratProvisoire is Stage)
                    {
                        cbxTypeContrat.SelectedItem = TypeContrat.Stage;
                        Stage stage = contrat as Stage;
                        txtEcole.Text = stage.Ecole;
                        txtMission.Text = stage.Mission;

                        displayFormStage();
                    }
                    if (contratProvisoire is MissionInterim)
                    {
                        cbxTypeContrat.SelectedItem = TypeContrat.Interim;
                        MissionInterim mission = contrat as MissionInterim;
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

        /// <summary>
        /// D
        /// </summary>
        private void DisplayFormCdd()
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

        private Contrat getContrat()
        {
            
            if (contrat == null)
            {
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
                        DateTime finContrat = dtpFinContrat.Value.Date;
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
        
            else return contrat;
                
                
            

        }

        private void cbxTypeContrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTypeContrat.SelectedItem.ToString() == TypeContrat.CDD.ToString())
            {
                DisplayFormCdd();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            contrat = getContrat();
            if (contrat != null)
            {
                SavingContrat?.Invoke(contrat);
                this.Close();
            }

        }

        private void btnCloturer_Click(object sender, EventArgs e)
        {
            if(contrat != null)
            {
                CloturingContrat?.Invoke(sender, e);
                this.Close();
            }
        }

    }
}
