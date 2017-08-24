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
    public partial class ContratForm : Form
    {
        public ContratForm()
        {
            InitializeComponent();
            cbxStatut.DataSource = Enum.GetValues(typeof(Statut));
        }
    }
}
