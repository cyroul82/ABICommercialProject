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
        public CloturingContratHandler CloturingContrat;
        private Contrat contrat;
        public ClotureForm(Contrat contrat)
        {
            InitializeComponent();
            this.contrat = contrat;
        }

        private void btnCloturer_Click(object sender, EventArgs e)
        {
            CloturingContrat?.Invoke();
        }
    }
}
