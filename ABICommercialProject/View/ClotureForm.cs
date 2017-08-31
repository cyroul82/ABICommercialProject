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
        public ClotureHandler onClotured;
        public ClotureForm()
        {
            InitializeComponent();
        }

        private void lblCloture_Click(object sender, EventArgs e)
        {
            onClotured();
        }
    }
}
