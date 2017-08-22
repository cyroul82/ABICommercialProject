using ABICommercialProject.Controller;
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
    public partial class CollaborateurView : Form
    {

        CollaborateurController cc;
        private BindingSource bindingSourceCollabo;

        public CollaborateurView()
        {
            InitializeComponent();
            cc = new CollaborateurController();
            bindingSourceCollabo = new BindingSource();
            bindingSourceCollabo.DataSource = cc.getCollaborateurs();
            collaborateurDataGrid.DataSource = bindingSourceCollabo;
        }

        public void addCollaborateur()
        {
            
        }
    }

}
