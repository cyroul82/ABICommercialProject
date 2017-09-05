namespace ABICommercialProject.View
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
            this.btnCloturer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
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
            // btnCloturer
            // 
            this.btnCloturer.Location = new System.Drawing.Point(84, 219);
            this.btnCloturer.Name = "btnCloturer";
            this.btnCloturer.Size = new System.Drawing.Size(75, 23);
            this.btnCloturer.TabIndex = 4;
            this.btnCloturer.Text = "Clôturer";
            this.btnCloturer.UseVisualStyleBackColor = true;
            this.btnCloturer.Click += new System.EventHandler(this.btnCloturer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(186, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ClotureForm
            // 
            this.AcceptButton = this.btnCloturer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(345, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCloturer);
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
        private System.Windows.Forms.Button btnCloturer;
        private System.Windows.Forms.Button btnCancel;
    }
}