namespace ABICommercialProject.View
{
    partial class CollaborateurForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbCollaborateur = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.picBoxCollabo = new System.Windows.Forms.PictureBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtFonction = new System.Windows.Forms.TextBox();
            this.lblFonction = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxTypeContrat = new System.Windows.Forms.ComboBox();
            this.gpxTypeContrat = new System.Windows.Forms.GroupBox();
            this.lblTypeContrat = new System.Windows.Forms.Label();
            this.gpxDetailContrat = new System.Windows.Forms.GroupBox();
            this.txtMission = new System.Windows.Forms.TextBox();
            this.lblMisson = new System.Windows.Forms.Label();
            this.txtEcole = new System.Windows.Forms.TextBox();
            this.lblEcole = new System.Windows.Forms.Label();
            this.dtpFinContrat = new System.Windows.Forms.DateTimePicker();
            this.lblDateFinContrat = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.txtSalaire = new System.Windows.Forms.TextBox();
            this.cbxStatut = new System.Windows.Forms.ComboBox();
            this.lblQualification = new System.Windows.Forms.Label();
            this.dtpDebutContrat = new System.Windows.Forms.DateTimePicker();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.lblDateDebutContrat = new System.Windows.Forms.Label();
            this.lblSalaireBrut = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrenom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFonction = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderQualification = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSalaire = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMotif = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEcole = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMission = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAugmentation = new System.Windows.Forms.Button();
            this.btnCloturer = new System.Windows.Forms.Button();
            this.btnAvenant = new System.Windows.Forms.Button();
            this.gbCollaborateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCollabo)).BeginInit();
            this.gpxTypeContrat.SuspendLayout();
            this.gpxDetailContrat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFonction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQualification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSalaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEcole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMission)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCollaborateur
            // 
            this.gbCollaborateur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCollaborateur.Controls.Add(this.txtEmail);
            this.gbCollaborateur.Controls.Add(this.lblEmail);
            this.gbCollaborateur.Controls.Add(this.txtTel);
            this.gbCollaborateur.Controls.Add(this.lblTel);
            this.gbCollaborateur.Controls.Add(this.txtCodePostal);
            this.gbCollaborateur.Controls.Add(this.lblCodePostal);
            this.gbCollaborateur.Controls.Add(this.textBox2);
            this.gbCollaborateur.Controls.Add(this.lblVille);
            this.gbCollaborateur.Controls.Add(this.txtAdresse);
            this.gbCollaborateur.Controls.Add(this.lblAdresse);
            this.gbCollaborateur.Controls.Add(this.picBoxCollabo);
            this.gbCollaborateur.Controls.Add(this.txtPrenom);
            this.gbCollaborateur.Controls.Add(this.lblPrenom);
            this.gbCollaborateur.Controls.Add(this.txtNom);
            this.gbCollaborateur.Controls.Add(this.lblNom);
            this.gbCollaborateur.Location = new System.Drawing.Point(12, 12);
            this.gbCollaborateur.Name = "gbCollaborateur";
            this.gbCollaborateur.Size = new System.Drawing.Size(288, 389);
            this.gbCollaborateur.TabIndex = 0;
            this.gbCollaborateur.TabStop = false;
            this.gbCollaborateur.Text = "Collaborateur";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 345);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(33, 348);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email : ";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(112, 318);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(147, 20);
            this.txtTel.TabIndex = 14;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(33, 321);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(67, 13);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "Téléphone : ";
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(112, 292);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(66, 20);
            this.txtCodePostal.TabIndex = 12;
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(33, 295);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(73, 13);
            this.lblCodePostal.TabIndex = 11;
            this.lblCodePostal.Text = "Code Postal : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 10;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(33, 269);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(35, 13);
            this.lblVille.TabIndex = 9;
            this.lblVille.Text = "Ville : ";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(112, 193);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(147, 67);
            this.txtAdresse.TabIndex = 8;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(33, 196);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(54, 13);
            this.lblAdresse.TabIndex = 7;
            this.lblAdresse.Text = "Adresse : ";
            // 
            // picBoxCollabo
            // 
            this.picBoxCollabo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxCollabo.Location = new System.Drawing.Point(95, 19);
            this.picBoxCollabo.Name = "picBoxCollabo";
            this.picBoxCollabo.Size = new System.Drawing.Size(83, 102);
            this.picBoxCollabo.TabIndex = 6;
            this.picBoxCollabo.TabStop = false;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(112, 166);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(147, 20);
            this.txtPrenom.TabIndex = 3;
            this.txtPrenom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrenom_KeyUp);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(33, 169);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(52, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom : ";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(112, 136);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(147, 20);
            this.txtNom.TabIndex = 1;
            this.txtNom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNom_KeyUp);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(33, 139);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom : ";
            // 
            // txtFonction
            // 
            this.txtFonction.Location = new System.Drawing.Point(102, 28);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.Size = new System.Drawing.Size(204, 20);
            this.txtFonction.TabIndex = 5;
            this.txtFonction.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFonction_KeyUp);
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Location = new System.Drawing.Point(16, 31);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(57, 13);
            this.lblFonction.TabIndex = 4;
            this.lblFonction.Text = "Fonction : ";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(324, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(242, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxTypeContrat
            // 
            this.cbxTypeContrat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeContrat.FormattingEnabled = true;
            this.cbxTypeContrat.Items.AddRange(new object[] {
            "CDD",
            "Mission Intérim",
            "Stage",
            "CDI"});
            this.cbxTypeContrat.Location = new System.Drawing.Point(102, 59);
            this.cbxTypeContrat.Name = "cbxTypeContrat";
            this.cbxTypeContrat.Size = new System.Drawing.Size(204, 21);
            this.cbxTypeContrat.TabIndex = 10;
            this.cbxTypeContrat.SelectedIndexChanged += new System.EventHandler(this.cbxTypeContrat_SelectedIndexChanged);
            // 
            // gpxTypeContrat
            // 
            this.gpxTypeContrat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxTypeContrat.Controls.Add(this.lblTypeContrat);
            this.gpxTypeContrat.Controls.Add(this.cbxTypeContrat);
            this.gpxTypeContrat.Controls.Add(this.txtFonction);
            this.gpxTypeContrat.Controls.Add(this.lblFonction);
            this.gpxTypeContrat.Location = new System.Drawing.Point(306, 17);
            this.gpxTypeContrat.Name = "gpxTypeContrat";
            this.gpxTypeContrat.Size = new System.Drawing.Size(329, 99);
            this.gpxTypeContrat.TabIndex = 11;
            this.gpxTypeContrat.TabStop = false;
            this.gpxTypeContrat.Text = "Type Contrat";
            // 
            // lblTypeContrat
            // 
            this.lblTypeContrat.AutoSize = true;
            this.lblTypeContrat.Location = new System.Drawing.Point(16, 62);
            this.lblTypeContrat.Name = "lblTypeContrat";
            this.lblTypeContrat.Size = new System.Drawing.Size(77, 13);
            this.lblTypeContrat.TabIndex = 6;
            this.lblTypeContrat.Text = "Type Contrat : ";
            // 
            // gpxDetailContrat
            // 
            this.gpxDetailContrat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxDetailContrat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpxDetailContrat.Controls.Add(this.txtMission);
            this.gpxDetailContrat.Controls.Add(this.lblMisson);
            this.gpxDetailContrat.Controls.Add(this.txtEcole);
            this.gpxDetailContrat.Controls.Add(this.lblEcole);
            this.gpxDetailContrat.Controls.Add(this.dtpFinContrat);
            this.gpxDetailContrat.Controls.Add(this.lblDateFinContrat);
            this.gpxDetailContrat.Controls.Add(this.txtMotif);
            this.gpxDetailContrat.Controls.Add(this.lblMotif);
            this.gpxDetailContrat.Controls.Add(this.txtSalaire);
            this.gpxDetailContrat.Controls.Add(this.cbxStatut);
            this.gpxDetailContrat.Controls.Add(this.lblQualification);
            this.gpxDetailContrat.Controls.Add(this.dtpDebutContrat);
            this.gpxDetailContrat.Controls.Add(this.txtQualification);
            this.gpxDetailContrat.Controls.Add(this.lblDateDebutContrat);
            this.gpxDetailContrat.Controls.Add(this.lblSalaireBrut);
            this.gpxDetailContrat.Controls.Add(this.lblStatut);
            this.gpxDetailContrat.Location = new System.Drawing.Point(306, 122);
            this.gpxDetailContrat.Name = "gpxDetailContrat";
            this.gpxDetailContrat.Size = new System.Drawing.Size(329, 279);
            this.gpxDetailContrat.TabIndex = 12;
            this.gpxDetailContrat.TabStop = false;
            this.gpxDetailContrat.Text = "Détails Contrat";
            // 
            // txtMission
            // 
            this.txtMission.Location = new System.Drawing.Point(102, 213);
            this.txtMission.Name = "txtMission";
            this.txtMission.Size = new System.Drawing.Size(204, 20);
            this.txtMission.TabIndex = 25;
            this.txtMission.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMission_KeyUp);
            // 
            // lblMisson
            // 
            this.lblMisson.AutoSize = true;
            this.lblMisson.Location = new System.Drawing.Point(16, 217);
            this.lblMisson.Name = "lblMisson";
            this.lblMisson.Size = new System.Drawing.Size(48, 13);
            this.lblMisson.TabIndex = 24;
            this.lblMisson.Text = "Mission :";
            // 
            // txtEcole
            // 
            this.txtEcole.Location = new System.Drawing.Point(102, 187);
            this.txtEcole.Name = "txtEcole";
            this.txtEcole.Size = new System.Drawing.Size(204, 20);
            this.txtEcole.TabIndex = 23;
            this.txtEcole.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEcole_KeyUp);
            // 
            // lblEcole
            // 
            this.lblEcole.AutoSize = true;
            this.lblEcole.Location = new System.Drawing.Point(16, 191);
            this.lblEcole.Name = "lblEcole";
            this.lblEcole.Size = new System.Drawing.Size(40, 13);
            this.lblEcole.TabIndex = 22;
            this.lblEcole.Text = "Ecole :";
            // 
            // dtpFinContrat
            // 
            this.dtpFinContrat.Location = new System.Drawing.Point(102, 133);
            this.dtpFinContrat.Name = "dtpFinContrat";
            this.dtpFinContrat.Size = new System.Drawing.Size(204, 20);
            this.dtpFinContrat.TabIndex = 21;
            // 
            // lblDateFinContrat
            // 
            this.lblDateFinContrat.AutoSize = true;
            this.lblDateFinContrat.Location = new System.Drawing.Point(16, 137);
            this.lblDateFinContrat.Name = "lblDateFinContrat";
            this.lblDateFinContrat.Size = new System.Drawing.Size(64, 13);
            this.lblDateFinContrat.TabIndex = 20;
            this.lblDateFinContrat.Text = "Fin Contrat :";
            this.lblDateFinContrat.Visible = false;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(102, 159);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(204, 20);
            this.txtMotif.TabIndex = 19;
            this.txtMotif.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMotif_KeyUp);
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(16, 163);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 13);
            this.lblMotif.TabIndex = 18;
            this.lblMotif.Text = "Motif :";
            // 
            // txtSalaire
            // 
            this.txtSalaire.Location = new System.Drawing.Point(102, 81);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(204, 20);
            this.txtSalaire.TabIndex = 15;
            this.txtSalaire.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSalaire_KeyUp);
            // 
            // cbxStatut
            // 
            this.cbxStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatut.FormattingEnabled = true;
            this.cbxStatut.Location = new System.Drawing.Point(102, 54);
            this.cbxStatut.Name = "cbxStatut";
            this.cbxStatut.Size = new System.Drawing.Size(204, 21);
            this.cbxStatut.TabIndex = 17;
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.Location = new System.Drawing.Point(16, 33);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(71, 13);
            this.lblQualification.TabIndex = 10;
            this.lblQualification.Text = "Qualification :";
            // 
            // dtpDebutContrat
            // 
            this.dtpDebutContrat.Location = new System.Drawing.Point(102, 107);
            this.dtpDebutContrat.Name = "dtpDebutContrat";
            this.dtpDebutContrat.Size = new System.Drawing.Size(204, 20);
            this.dtpDebutContrat.TabIndex = 16;
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(102, 30);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(204, 20);
            this.txtQualification.TabIndex = 11;
            this.txtQualification.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQualification_KeyUp);
            // 
            // lblDateDebutContrat
            // 
            this.lblDateDebutContrat.AutoSize = true;
            this.lblDateDebutContrat.Location = new System.Drawing.Point(16, 110);
            this.lblDateDebutContrat.Name = "lblDateDebutContrat";
            this.lblDateDebutContrat.Size = new System.Drawing.Size(79, 13);
            this.lblDateDebutContrat.TabIndex = 12;
            this.lblDateDebutContrat.Text = "Début Contrat :";
            // 
            // lblSalaireBrut
            // 
            this.lblSalaireBrut.AutoSize = true;
            this.lblSalaireBrut.Location = new System.Drawing.Point(16, 85);
            this.lblSalaireBrut.Name = "lblSalaireBrut";
            this.lblSalaireBrut.Size = new System.Drawing.Size(67, 13);
            this.lblSalaireBrut.TabIndex = 14;
            this.lblSalaireBrut.Text = "Salaire Brut :";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(16, 57);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(41, 13);
            this.lblStatut.TabIndex = 13;
            this.lblStatut.Text = "Statut :";
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNom.ContainerControl = this;
            // 
            // errorProviderPrenom
            // 
            this.errorProviderPrenom.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPrenom.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProviderFonction
            // 
            this.errorProviderFonction.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFonction.ContainerControl = this;
            // 
            // errorProviderQualification
            // 
            this.errorProviderQualification.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderQualification.ContainerControl = this;
            // 
            // errorProviderSalaire
            // 
            this.errorProviderSalaire.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderSalaire.ContainerControl = this;
            // 
            // errorProviderMotif
            // 
            this.errorProviderMotif.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMotif.ContainerControl = this;
            // 
            // errorProviderEcole
            // 
            this.errorProviderEcole.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderEcole.ContainerControl = this;
            // 
            // errorProviderMission
            // 
            this.errorProviderMission.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMission.ContainerControl = this;
            // 
            // btnAugmentation
            // 
            this.btnAugmentation.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAugmentation.Location = new System.Drawing.Point(10, 407);
            this.btnAugmentation.Name = "btnAugmentation";
            this.btnAugmentation.Size = new System.Drawing.Size(89, 23);
            this.btnAugmentation.TabIndex = 13;
            this.btnAugmentation.Text = "Augmentation";
            this.btnAugmentation.UseVisualStyleBackColor = true;
            // 
            // btnCloturer
            // 
            this.btnCloturer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloturer.Location = new System.Drawing.Point(560, 407);
            this.btnCloturer.Name = "btnCloturer";
            this.btnCloturer.Size = new System.Drawing.Size(75, 23);
            this.btnCloturer.TabIndex = 14;
            this.btnCloturer.Text = "Clôturer";
            this.btnCloturer.UseVisualStyleBackColor = true;
            this.btnCloturer.Click += new System.EventHandler(this.btnCloturer_Click);
            // 
            // btnAvenant
            // 
            this.btnAvenant.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAvenant.Location = new System.Drawing.Point(465, 407);
            this.btnAvenant.Name = "btnAvenant";
            this.btnAvenant.Size = new System.Drawing.Size(89, 23);
            this.btnAvenant.TabIndex = 15;
            this.btnAvenant.Text = "Avenant";
            this.btnAvenant.UseVisualStyleBackColor = true;
            // 
            // CollaborateurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 443);
            this.Controls.Add(this.btnAvenant);
            this.Controls.Add(this.btnCloturer);
            this.Controls.Add(this.btnAugmentation);
            this.Controls.Add(this.gpxTypeContrat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbCollaborateur);
            this.Controls.Add(this.gpxDetailContrat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CollaborateurForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CollaborateurForm";
            this.gbCollaborateur.ResumeLayout(false);
            this.gbCollaborateur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCollabo)).EndInit();
            this.gpxTypeContrat.ResumeLayout(false);
            this.gpxTypeContrat.PerformLayout();
            this.gpxDetailContrat.ResumeLayout(false);
            this.gpxDetailContrat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFonction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQualification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSalaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEcole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCollaborateur;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtFonction;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxTypeContrat;
        private System.Windows.Forms.GroupBox gpxTypeContrat;
        private System.Windows.Forms.Label lblTypeContrat;
        private System.Windows.Forms.GroupBox gpxDetailContrat;
        private System.Windows.Forms.TextBox txtSalaire;
        private System.Windows.Forms.ComboBox cbxStatut;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.DateTimePicker dtpDebutContrat;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label lblDateDebutContrat;
        private System.Windows.Forms.Label lblSalaireBrut;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.DateTimePicker dtpFinContrat;
        private System.Windows.Forms.Label lblDateFinContrat;
        private System.Windows.Forms.TextBox txtEcole;
        private System.Windows.Forms.Label lblEcole;
        private System.Windows.Forms.TextBox txtMission;
        private System.Windows.Forms.Label lblMisson;
        private System.Windows.Forms.ErrorProvider errorProviderNom;
        private System.Windows.Forms.ErrorProvider errorProviderPrenom;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProviderFonction;
        private System.Windows.Forms.ErrorProvider errorProviderQualification;
        private System.Windows.Forms.ErrorProvider errorProviderSalaire;
        private System.Windows.Forms.ErrorProvider errorProviderMotif;
        private System.Windows.Forms.ErrorProvider errorProviderEcole;
        private System.Windows.Forms.ErrorProvider errorProviderMission;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.PictureBox picBoxCollabo;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAvenant;
        private System.Windows.Forms.Button btnCloturer;
        private System.Windows.Forms.Button btnAugmentation;
    }
}