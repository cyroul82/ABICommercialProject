using ABIModel;
using System;
using System.Windows.Forms;

namespace ABIView
{
    
    public partial class CollaborateurForm : Form
    {

        private Collaborateur collaborateur;

        public CollaboHandler SavingCollabo;
        public EventHandler UpdatingCollabo;
        public EventHandler CloturingContrat;
        public EventHandler ListContrat;

        public CollaboHandler EditingCollabo;

        public CollaborateurForm()
        {
            InitializeComponent();
            SetFormToNewCollabo();
            
        }

        public CollaborateurForm(Boolean edit)
        {
            InitializeComponent();
            if (edit)
            {
                SetFormToEditCollabo();
            }
            else
            {
                SetFormToDetailCollabo();
            }
        }

        public void SetCollaborateur(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            this.Text = collaborateur.Name + " " + collaborateur.Firstname;

            SetCollaborateur();
        }


        private void SetFormToNewCollabo()
        {
            collaborateur = null;
            SetActionControlEnabled(false);
            SetCollaborateurControlEnabled(false);
            btnSave.Text = Tools.create;
        }

        private void SetFormToDetailCollabo()
        {
            SetActionControlEnabled(true);
            SetCollaborateurControlEnabled(true);
            btnSave.Text = Tools.edit;
            btnCancel.Text = Tools.close;
        }

        private void SetFormToEditCollabo()
        {
            SetActionControlEnabled(false);
            SetCollaborateurControlEnabled(false);
        }
        
        /// <summary>
        /// set buttons Augmentation, Avenant, Cloturer to param
        /// </summary>
        /// <param name="enable"></param>
        private void SetActionControlEnabled(Boolean enable)
        {
            btnAugmentation.Visible = enable;
            lblMatricule.Visible = enable;
            lblTextMatricule.Visible = enable;
        }

        /// <summary>
        /// Set All textboxes related to Collaborateur to param
        /// </summary>
        /// <param name="enable"></param>
        private void SetCollaborateurControlEnabled(Boolean enable)
        {
            txtNom.ReadOnly = enable;
            txtPrenom.ReadOnly = enable;
            txtEmail.ReadOnly = enable;
            txtCodePostal.ReadOnly = enable;
            txtAdresse.ReadOnly = enable;
            txtTel.ReadOnly = enable;
            txtVille.ReadOnly = enable;
            txtFonction.ReadOnly = enable;
        }

        private void SetCollaborateur()
        {
            txtNom.Text = collaborateur.Name;
            txtPrenom.Text = collaborateur.Firstname;
            txtFonction.Text = collaborateur.FonctionCollabo;
            txtAdresse.Text = collaborateur.Address;
            txtCodePostal.Text = collaborateur.ZipCode;
            txtVille.Text = collaborateur.Town;
            txtTel.Text = collaborateur.Tel;
            txtEmail.Text = collaborateur.Email;
            lblTextMatricule.Text = collaborateur.Id.ToString();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (sender is DialogResult)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                this.Close();
            }
        }

        public void CloseDialog()
        {
            this.DialogResult = DialogResult.OK;
        }

        public void DisplayDialog()
        {
            this.ShowDialog();
        }

       

        /// <summary>
        /// Get the the data from the textbox, create a collaborateur and return it
        /// </summary>
        /// <returns></returns>
        public Collaborateur GetCollaborateur()
        {
            return collaborateur;
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (SavedCollabo())
            {
                if (btnSave.Text == Tools.create) SavingCollabo?.Invoke(GetCollaborateur());
                if (btnSave.Text == Tools.edit) EditingCollabo?.Invoke(GetCollaborateur());
                if (btnSave.Text == Tools.update) UpdatingCollabo?.Invoke(sender, e);
            }
        }
        

        private Boolean SavedCollabo()
        {
            try
            {
                if (String.IsNullOrEmpty(txtNom.Text) || String.IsNullOrEmpty(txtPrenom.Text))
                {
                    errorProviderNom.SetError(txtNom, "Requis");
                    errorProviderPrenom.SetError(txtPrenom, "Requis");
                    return false;
               
                }
                else
                {
                    String nom = txtNom.Text.Trim().ToUpper();
                    String prenom = Tools.FirstLetterUppercase(txtPrenom.Text.Trim());
                    String fonction = txtFonction.Text.Trim();
                    String address = txtAdresse.Text.Trim();
                    String zipCode = txtCodePostal.Text.Trim();
                    String town = txtVille.Text.Trim();
                    String tel = txtTel.Text.Trim();
                    String email = txtEmail.Text.Trim();

                    if (collaborateur == null)
                    {
                        collaborateur = new Collaborateur(nom, prenom, fonction, address, zipCode, town, tel, email);
                        return true;
                    }
                    else
                    {
                        collaborateur.Name = nom;
                        collaborateur.Firstname = prenom;
                        collaborateur.FonctionCollabo = fonction;
                        collaborateur.Address = address;
                        collaborateur.ZipCode = zipCode;
                        collaborateur.Town = town;
                        collaborateur.Tel = tel;
                        collaborateur.Email = email;
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Creation Collaborateur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void DisplayErrorMessage(String message, String title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
