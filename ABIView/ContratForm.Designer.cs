namespace ABIView
{
    partial class ContratForm
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
            this.errorProviderQualification = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSalaire = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMotif = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEcole = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMission = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContrat = new System.Windows.Forms.Panel();
            this.gpxTypeContrat = new System.Windows.Forms.GroupBox();
            this.lblTypeContrat = new System.Windows.Forms.Label();
            this.cbxTypeContrat = new System.Windows.Forms.ComboBox();
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCloturer = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAvenant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQualification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSalaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEcole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMission)).BeginInit();
            this.panelContrat.SuspendLayout();
            this.gpxTypeContrat.SuspendLayout();
            this.gpxDetailContrat.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // panelContrat
            // 
            this.panelContrat.Controls.Add(this.gpxTypeContrat);
            this.panelContrat.Controls.Add(this.gpxDetailContrat);
            this.panelContrat.Location = new System.Drawing.Point(12, 12);
            this.panelContrat.Name = "panelContrat";
            this.panelContrat.Size = new System.Drawing.Size(351, 420);
            this.panelContrat.TabIndex = 22;
            // 
            // gpxTypeContrat
            // 
            this.gpxTypeContrat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxTypeContrat.Controls.Add(this.lblTypeContrat);
            this.gpxTypeContrat.Controls.Add(this.cbxTypeContrat);
            this.gpxTypeContrat.Location = new System.Drawing.Point(7, -2);
            this.gpxTypeContrat.Name = "gpxTypeContrat";
            this.gpxTypeContrat.Size = new System.Drawing.Size(337, 64);
            this.gpxTypeContrat.TabIndex = 19;
            this.gpxTypeContrat.TabStop = false;
            this.gpxTypeContrat.Text = "Type Contrat";
            // 
            // lblTypeContrat
            // 
            this.lblTypeContrat.AutoSize = true;
            this.lblTypeContrat.Location = new System.Drawing.Point(16, 32);
            this.lblTypeContrat.Name = "lblTypeContrat";
            this.lblTypeContrat.Size = new System.Drawing.Size(77, 13);
            this.lblTypeContrat.TabIndex = 6;
            this.lblTypeContrat.Text = "Type Contrat : ";
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
            this.cbxTypeContrat.Location = new System.Drawing.Point(102, 29);
            this.cbxTypeContrat.Name = "cbxTypeContrat";
            this.cbxTypeContrat.Size = new System.Drawing.Size(204, 21);
            this.cbxTypeContrat.TabIndex = 1;
            this.cbxTypeContrat.SelectedIndexChanged += new System.EventHandler(this.cbxTypeContrat_SelectedIndexChanged);
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
            this.gpxDetailContrat.Location = new System.Drawing.Point(7, 68);
            this.gpxDetailContrat.Name = "gpxDetailContrat";
            this.gpxDetailContrat.Size = new System.Drawing.Size(337, 349);
            this.gpxDetailContrat.TabIndex = 20;
            this.gpxDetailContrat.TabStop = false;
            this.gpxDetailContrat.Text = "Détails Contrat";
            // 
            // txtMission
            // 
            this.txtMission.Location = new System.Drawing.Point(102, 213);
            this.txtMission.Name = "txtMission";
            this.txtMission.Size = new System.Drawing.Size(204, 20);
            this.txtMission.TabIndex = 9;
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
            this.txtEcole.TabIndex = 8;
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
            this.dtpFinContrat.TabIndex = 6;
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
            this.txtMotif.TabIndex = 7;
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
            this.txtSalaire.TabIndex = 4;
            // 
            // cbxStatut
            // 
            this.cbxStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatut.FormattingEnabled = true;
            this.cbxStatut.Location = new System.Drawing.Point(102, 54);
            this.cbxStatut.Name = "cbxStatut";
            this.cbxStatut.Size = new System.Drawing.Size(204, 21);
            this.cbxStatut.TabIndex = 3;
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
            this.dtpDebutContrat.TabIndex = 5;
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(102, 30);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(204, 20);
            this.txtQualification.TabIndex = 2;
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
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(246, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCloturer
            // 
            this.btnCloturer.Location = new System.Drawing.Point(84, 3);
            this.btnCloturer.Name = "btnCloturer";
            this.btnCloturer.Size = new System.Drawing.Size(75, 23);
            this.btnCloturer.TabIndex = 11;
            this.btnCloturer.Text = "Clôturer";
            this.btnCloturer.UseVisualStyleBackColor = true;
            this.btnCloturer.Click += new System.EventHandler(this.btnCloturer_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnCloturer);
            this.flowLayoutPanel1.Controls.Add(this.btnAvenant);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 441);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(324, 29);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // btnAvenant
            // 
            this.btnAvenant.Location = new System.Drawing.Point(165, 3);
            this.btnAvenant.Name = "btnAvenant";
            this.btnAvenant.Size = new System.Drawing.Size(75, 23);
            this.btnAvenant.TabIndex = 12;
            this.btnAvenant.Text = "Avenants";
            this.btnAvenant.UseVisualStyleBackColor = true;
            // 
            // ContratForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(375, 482);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelContrat);
            this.Name = "ContratForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouveau Contrat";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQualification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSalaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEcole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMission)).EndInit();
            this.panelContrat.ResumeLayout(false);
            this.gpxTypeContrat.ResumeLayout(false);
            this.gpxTypeContrat.PerformLayout();
            this.gpxDetailContrat.ResumeLayout(false);
            this.gpxDetailContrat.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProviderQualification;
        private System.Windows.Forms.ErrorProvider errorProviderSalaire;
        private System.Windows.Forms.ErrorProvider errorProviderMotif;
        private System.Windows.Forms.ErrorProvider errorProviderEcole;
        private System.Windows.Forms.ErrorProvider errorProviderMission;
        private System.Windows.Forms.Panel panelContrat;
        private System.Windows.Forms.GroupBox gpxTypeContrat;
        private System.Windows.Forms.Label lblTypeContrat;
        private System.Windows.Forms.ComboBox cbxTypeContrat;
        private System.Windows.Forms.GroupBox gpxDetailContrat;
        private System.Windows.Forms.TextBox txtMission;
        private System.Windows.Forms.Label lblMisson;
        private System.Windows.Forms.TextBox txtEcole;
        private System.Windows.Forms.Label lblEcole;
        private System.Windows.Forms.DateTimePicker dtpFinContrat;
        private System.Windows.Forms.Label lblDateFinContrat;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txtSalaire;
        private System.Windows.Forms.ComboBox cbxStatut;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.DateTimePicker dtpDebutContrat;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label lblDateDebutContrat;
        private System.Windows.Forms.Label lblSalaireBrut;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCloturer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAvenant;
    }
}