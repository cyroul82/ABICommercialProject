namespace ABICommercialProject.View
{
    partial class CollaborateurView
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
            this.collaborateurDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.collaborateurDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // collaborateurDataGrid
            // 
            this.collaborateurDataGrid.AllowUserToAddRows = false;
            this.collaborateurDataGrid.AllowUserToDeleteRows = false;
            this.collaborateurDataGrid.AllowUserToResizeRows = false;
            this.collaborateurDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.collaborateurDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.collaborateurDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.collaborateurDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.collaborateurDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.collaborateurDataGrid.Location = new System.Drawing.Point(12, 12);
            this.collaborateurDataGrid.MultiSelect = false;
            this.collaborateurDataGrid.Name = "collaborateurDataGrid";
            this.collaborateurDataGrid.ReadOnly = true;
            this.collaborateurDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.collaborateurDataGrid.Size = new System.Drawing.Size(271, 362);
            this.collaborateurDataGrid.TabIndex = 0;
            // 
            // CollaborateurView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 386);
            this.Controls.Add(this.collaborateurDataGrid);
            this.Name = "CollaborateurView";
            this.Text = "CollobarateurView";
            ((System.ComponentModel.ISupportInitialize)(this.collaborateurDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView collaborateurDataGrid;
    }
}