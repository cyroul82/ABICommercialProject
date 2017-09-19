namespace ABIView
{
    partial class CollaborateurListForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewCollabo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.collaborateurDataGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // collaborateurDataGrid
            // 
            this.collaborateurDataGrid.AllowUserToAddRows = false;
            this.collaborateurDataGrid.AllowUserToDeleteRows = false;
            this.collaborateurDataGrid.AllowUserToOrderColumns = true;
            this.collaborateurDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.collaborateurDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.collaborateurDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.collaborateurDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.collaborateurDataGrid.Location = new System.Drawing.Point(12, 44);
            this.collaborateurDataGrid.MultiSelect = false;
            this.collaborateurDataGrid.Name = "collaborateurDataGrid";
            this.collaborateurDataGrid.ReadOnly = true;
            this.collaborateurDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.collaborateurDataGrid.Size = new System.Drawing.Size(639, 419);
            this.collaborateurDataGrid.TabIndex = 4;
            this.collaborateurDataGrid.SelectionChanged += new System.EventHandler(this.collaborateurDataGrid_SelectionChanged);
            this.collaborateurDataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.collaborateurDataGrid_MouseClick);
            this.collaborateurDataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.collaborateurDataGrid_MouseDoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnNewCollabo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(639, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNewCollabo
            // 
            this.btnNewCollabo.Location = new System.Drawing.Point(3, 3);
            this.btnNewCollabo.Name = "btnNewCollabo";
            this.btnNewCollabo.Size = new System.Drawing.Size(75, 23);
            this.btnNewCollabo.TabIndex = 5;
            this.btnNewCollabo.Text = "Nouveau";
            this.btnNewCollabo.UseVisualStyleBackColor = true;
            this.btnNewCollabo.Click += new System.EventHandler(this.btnNewCollabo_Click);
            // 
            // CollaborateurListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 472);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.collaborateurDataGrid);
            this.Name = "CollaborateurListForm";
            this.Text = "CollobarateurView";
            ((System.ComponentModel.ISupportInitialize)(this.collaborateurDataGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNewCollabo;
        private System.Windows.Forms.DataGridView collaborateurDataGrid;
    }
}