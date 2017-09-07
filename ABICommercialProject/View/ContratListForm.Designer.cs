namespace ABICommercialProject.View
{
    partial class ContratListForm
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
            this.grdListContrat = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdListContrat)).BeginInit();
            this.SuspendLayout();
            // 
            // grdListContrat
            // 
            this.grdListContrat.AllowUserToAddRows = false;
            this.grdListContrat.AllowUserToDeleteRows = false;
            this.grdListContrat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdListContrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListContrat.Location = new System.Drawing.Point(12, 41);
            this.grdListContrat.MultiSelect = false;
            this.grdListContrat.Name = "grdListContrat";
            this.grdListContrat.ReadOnly = true;
            this.grdListContrat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListContrat.Size = new System.Drawing.Size(759, 289);
            this.grdListContrat.TabIndex = 0;
            this.grdListContrat.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdListContrat_MouseDoubleClick);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ContratListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 342);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grdListContrat);
            this.Name = "ContratListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ContratList";
            ((System.ComponentModel.ISupportInitialize)(this.grdListContrat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdListContrat;
        private System.Windows.Forms.Button btnNew;
    }
}