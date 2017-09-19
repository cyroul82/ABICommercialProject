namespace ABIView
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrenom = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbCollaborateur = new System.Windows.Forms.GroupBox();
            this.lblTextMatricule = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFonction = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblFonction = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.picBoxCollabo = new System.Windows.Forms.PictureBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnAugmentation = new System.Windows.Forms.Button();
            this.panelContrat = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrenom)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbCollaborateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCollabo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(135, 456);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(54, 456);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.gbCollaborateur);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 432);
            this.panel1.TabIndex = 11;
            // 
            // gbCollaborateur
            // 
            this.gbCollaborateur.Controls.Add(this.lblTextMatricule);
            this.gbCollaborateur.Controls.Add(this.lblMatricule);
            this.gbCollaborateur.Controls.Add(this.txtEmail);
            this.gbCollaborateur.Controls.Add(this.lblEmail);
            this.gbCollaborateur.Controls.Add(this.txtFonction);
            this.gbCollaborateur.Controls.Add(this.txtTel);
            this.gbCollaborateur.Controls.Add(this.lblFonction);
            this.gbCollaborateur.Controls.Add(this.lblTel);
            this.gbCollaborateur.Controls.Add(this.txtCodePostal);
            this.gbCollaborateur.Controls.Add(this.lblCodePostal);
            this.gbCollaborateur.Controls.Add(this.txtVille);
            this.gbCollaborateur.Controls.Add(this.lblVille);
            this.gbCollaborateur.Controls.Add(this.txtAdresse);
            this.gbCollaborateur.Controls.Add(this.lblAdresse);
            this.gbCollaborateur.Controls.Add(this.picBoxCollabo);
            this.gbCollaborateur.Controls.Add(this.txtPrenom);
            this.gbCollaborateur.Controls.Add(this.lblPrenom);
            this.gbCollaborateur.Controls.Add(this.txtNom);
            this.gbCollaborateur.Controls.Add(this.lblNom);
            this.gbCollaborateur.Location = new System.Drawing.Point(11, 3);
            this.gbCollaborateur.Name = "gbCollaborateur";
            this.gbCollaborateur.Size = new System.Drawing.Size(282, 417);
            this.gbCollaborateur.TabIndex = 1;
            this.gbCollaborateur.TabStop = false;
            this.gbCollaborateur.Text = "Collaborateur";
            // 
            // lblTextMatricule
            // 
            this.lblTextMatricule.AutoSize = true;
            this.lblTextMatricule.Location = new System.Drawing.Point(200, 112);
            this.lblTextMatricule.Name = "lblTextMatricule";
            this.lblTextMatricule.Size = new System.Drawing.Size(0, 13);
            this.lblTextMatricule.TabIndex = 18;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(143, 112);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(59, 13);
            this.lblMatricule.TabIndex = 17;
            this.lblMatricule.Text = "Matricule : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 345);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 7;
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
            // txtFonction
            // 
            this.txtFonction.Location = new System.Drawing.Point(112, 373);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.Size = new System.Drawing.Size(147, 20);
            this.txtFonction.TabIndex = 8;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(112, 318);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(147, 20);
            this.txtTel.TabIndex = 6;
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Location = new System.Drawing.Point(28, 373);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(57, 13);
            this.lblFonction.TabIndex = 4;
            this.lblFonction.Text = "Fonction : ";
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
            this.txtCodePostal.TabIndex = 5;
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
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(112, 266);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(147, 20);
            this.txtVille.TabIndex = 4;
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
            this.txtAdresse.TabIndex = 3;
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
            this.picBoxCollabo.Location = new System.Drawing.Point(36, 19);
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
            this.txtPrenom.TabIndex = 2;
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
            // btnAugmentation
            // 
            this.btnAugmentation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAugmentation.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAugmentation.Location = new System.Drawing.Point(216, 456);
            this.btnAugmentation.Name = "btnAugmentation";
            this.btnAugmentation.Size = new System.Drawing.Size(89, 23);
            this.btnAugmentation.TabIndex = 13;
            this.btnAugmentation.Text = "Augmentation";
            this.btnAugmentation.UseVisualStyleBackColor = true;
            // 
            // panelContrat
            // 
            this.panelContrat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContrat.Location = new System.Drawing.Point(324, 12);
            this.panelContrat.Name = "panelContrat";
            this.panelContrat.Size = new System.Drawing.Size(0, 432);
            this.panelContrat.TabIndex = 12;
            // 
            // CollaborateurForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(327, 491);
            this.Controls.Add(this.panelContrat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAugmentation);
            this.Controls.Add(this.btnSave);
            this.Name = "CollaborateurForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouveau Collaborateur";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrenom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbCollaborateur.ResumeLayout(false);
            this.gbCollaborateur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCollabo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProviderNom;
        private System.Windows.Forms.ErrorProvider errorProviderPrenom;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbCollaborateur;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAugmentation;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFonction;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.PictureBox picBoxCollabo;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTextMatricule;
        private System.Windows.Forms.Label lblMatricule;
        public System.Windows.Forms.Panel panelContrat;
    }
}