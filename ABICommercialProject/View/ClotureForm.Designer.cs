﻿namespace ABICommercialProject.View
{
    partial class ClotureForm
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
            this.dtpFinEffecif = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblCloture = new System.Windows.Forms.Button();
            this.lblCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFinEffecif
            // 
            this.dtpFinEffecif.Location = new System.Drawing.Point(113, 75);
            this.dtpFinEffecif.Name = "dtpFinEffecif";
            this.dtpFinEffecif.Size = new System.Drawing.Size(200, 20);
            this.dtpFinEffecif.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(26, 81);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date Clôture :";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(62, 127);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 13);
            this.lblMotif.TabIndex = 2;
            this.lblMotif.Text = "Motif :";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(113, 127);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(200, 67);
            this.txtMotif.TabIndex = 3;
            // 
            // lblCloture
            // 
            this.lblCloture.Location = new System.Drawing.Point(84, 219);
            this.lblCloture.Name = "lblCloture";
            this.lblCloture.Size = new System.Drawing.Size(75, 23);
            this.lblCloture.TabIndex = 4;
            this.lblCloture.Text = "Clôturer";
            this.lblCloture.UseVisualStyleBackColor = true;
            this.lblCloture.Click += new System.EventHandler(this.lblCloture_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.Location = new System.Drawing.Point(186, 219);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(75, 23);
            this.lblCancel.TabIndex = 5;
            this.lblCancel.Text = "Annuler";
            this.lblCancel.UseVisualStyleBackColor = true;
            // 
            // ClotureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 261);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.lblCloture);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpFinEffecif);
            this.Name = "ClotureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClotureForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFinEffecif;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Button lblCloture;
        private System.Windows.Forms.Button lblCancel;
    }
}