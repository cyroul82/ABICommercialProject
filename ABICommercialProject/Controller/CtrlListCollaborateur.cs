using ABICommercialProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABICommercialProject.Controller
{
    public class CtrlListCollaborateur
    {
        CollaborateurList cv;
        public CtrlListCollaborateur()
        {
            cv = new CollaborateurList();
            cv.FormClosing += new FormClosingEventHandler(this.collobarateurViewClosing);
            cv.MdiParent = MainApp.getInstance();
            cv.Show();
        }

        private void collobarateurViewClosing(object sender, FormClosingEventArgs e)
        {
            cv = null;
            MainApp.getInstance().ctrl = null;
        }

        public void display()
        {
            cv.Activate();
        }
    }
}
