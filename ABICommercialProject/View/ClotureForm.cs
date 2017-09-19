using ABIModel;
using System;
using System.Windows.Forms;

namespace ABICommercialProject.View
{
    public partial class ClotureForm : Form
    {
        private Contrat contrat;
        public ClotureForm(ref Contrat contrat)
        {
            InitializeComponent();
            this.contrat = contrat;
        }

        private void BtnCloturer_Click(object sender, EventArgs e)
        {
            if(dtpFinEffecif.Text != "" && txtMotif.Text != "")
            {
                try
                {
                    contrat.clotureContrat(dtpFinEffecif.Value.Date, txtMotif.Text);
                    this.DialogResult = DialogResult.OK;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Cloture", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }   

            }
            else
            {
                MessageBox.Show("Merci de renseigner les champs ", "Erreur champs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
