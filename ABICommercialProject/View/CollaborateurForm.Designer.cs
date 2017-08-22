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
            this.gbCollaborateur = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtFonction = new System.Windows.Forms.TextBox();
            this.lblFonction = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbCollaborateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCollaborateur
            // 
            this.gbCollaborateur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCollaborateur.Controls.Add(this.btnCancel);
            this.gbCollaborateur.Controls.Add(this.btnSave);
            this.gbCollaborateur.Controls.Add(this.txtFonction);
            this.gbCollaborateur.Controls.Add(this.lblFonction);
            this.gbCollaborateur.Controls.Add(this.txtPrenom);
            this.gbCollaborateur.Controls.Add(this.lblPrenom);
            this.gbCollaborateur.Controls.Add(this.txtNom);
            this.gbCollaborateur.Controls.Add(this.lblNom);
            this.gbCollaborateur.Location = new System.Drawing.Point(12, 12);
            this.gbCollaborateur.Name = "gbCollaborateur";
            this.gbCollaborateur.Size = new System.Drawing.Size(399, 261);
            this.gbCollaborateur.TabIndex = 0;
            this.gbCollaborateur.TabStop = false;
            this.gbCollaborateur.Text = "Collaborateur";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(16, 36);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom : ";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(84, 32);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(140, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(84, 58);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(140, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(16, 62);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(52, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom : ";
            // 
            // txtFonction
            // 
            this.txtFonction.Location = new System.Drawing.Point(84, 84);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.Size = new System.Drawing.Size(140, 20);
            this.txtFonction.TabIndex = 5;
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Location = new System.Drawing.Point(16, 88);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(57, 13);
            this.lblFonction.TabIndex = 4;
            this.lblFonction.Text = "Fonction : ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(133, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CollaborateurForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(423, 285);
            this.Controls.Add(this.gbCollaborateur);
            this.Name = "CollaborateurForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CollaborateurForm";
            this.gbCollaborateur.ResumeLayout(false);
            this.gbCollaborateur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCollaborateur;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFonction;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNom;
    }
}