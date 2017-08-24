﻿using System;
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
    
    public partial class ContratSelectForm : Form
    {
        public selectContrat contratSelection;
        public ContratSelectForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String choice = cbxTypeContrat.SelectedItem.ToString();
            contratSelection?.Invoke(choice);
        }
    }
}
