using ABICommercialProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnCloturer_Click(object sender, EventArgs e)
        {
            if(dtpFinEffecif.Text != "" && txtMotif.Text != "")
            {
                contrat.clotureContrat(dtpFinEffecif.Value.Date, txtMotif.Text);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Merci de renseigner les champs ", "Erreur champs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
