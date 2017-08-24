namespace ABICommercialProject.View
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
            this.lblQualification = new System.Windows.Forms.Label();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.lblDateDebutContrat = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblSalaireBrut = new System.Windows.Forms.Label();
            this.dtpDebutContrat = new System.Windows.Forms.DateTimePicker();
            this.cbxStatut = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.Location = new System.Drawing.Point(11, 30);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(71, 13);
            this.lblQualification.TabIndex = 0;
            this.lblQualification.Text = "Qualification :";
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(97, 27);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(214, 20);
            this.txtQualification.TabIndex = 1;
            // 
            // lblDateDebutContrat
            // 
            this.lblDateDebutContrat.AutoSize = true;
            this.lblDateDebutContrat.Location = new System.Drawing.Point(11, 56);
            this.lblDateDebutContrat.Name = "lblDateDebutContrat";
            this.lblDateDebutContrat.Size = new System.Drawing.Size(79, 13);
            this.lblDateDebutContrat.TabIndex = 2;
            this.lblDateDebutContrat.Text = "Début Contrat :";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(11, 82);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(41, 13);
            this.lblStatut.TabIndex = 4;
            this.lblStatut.Text = "Statut :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(214, 20);
            this.textBox4.TabIndex = 7;
            // 
            // lblSalaireBrut
            // 
            this.lblSalaireBrut.AutoSize = true;
            this.lblSalaireBrut.Location = new System.Drawing.Point(11, 109);
            this.lblSalaireBrut.Name = "lblSalaireBrut";
            this.lblSalaireBrut.Size = new System.Drawing.Size(67, 13);
            this.lblSalaireBrut.TabIndex = 6;
            this.lblSalaireBrut.Text = "Salaire Brut :";
            // 
            // dtpDebutContrat
            // 
            this.dtpDebutContrat.Location = new System.Drawing.Point(97, 53);
            this.dtpDebutContrat.Name = "dtpDebutContrat";
            this.dtpDebutContrat.Size = new System.Drawing.Size(214, 20);
            this.dtpDebutContrat.TabIndex = 8;
            // 
            // cbxStatut
            // 
            this.cbxStatut.FormattingEnabled = true;
            this.cbxStatut.Location = new System.Drawing.Point(97, 79);
            this.cbxStatut.Name = "cbxStatut";
            this.cbxStatut.Size = new System.Drawing.Size(214, 21);
            this.cbxStatut.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.cbxStatut);
            this.groupBox1.Controls.Add(this.lblQualification);
            this.groupBox1.Controls.Add(this.dtpDebutContrat);
            this.groupBox1.Controls.Add(this.txtQualification);
            this.groupBox1.Controls.Add(this.lblDateDebutContrat);
            this.groupBox1.Controls.Add(this.lblSalaireBrut);
            this.groupBox1.Controls.Add(this.lblStatut);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 198);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ContratForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 222);
            this.Controls.Add(this.groupBox1);
            this.Name = "ContratForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouveau Contrat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label lblDateDebutContrat;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblSalaireBrut;
        private System.Windows.Forms.DateTimePicker dtpDebutContrat;
        private System.Windows.Forms.ComboBox cbxStatut;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}