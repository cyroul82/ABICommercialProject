using ABICommercialProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABICommercialProject
{
    public partial class MainApp : Form
    {
        CollaborateurList cv;
        public MainApp()
        {
            InitializeComponent();
            Collaborateur c = new Collaborateur("Rat", "Cyril", "Concepteur");
            Collaborateur.collaborateurList.Add(c);
            c = new Collaborateur("Rat", "Chigusa", "Commercial");
            Collaborateur.collaborateurList.Add(c);
            c = new Collaborateur("Rat Ito", "Emma", "Designer");
            Collaborateur.collaborateurList.Add(c);
            c = new Collaborateur("Rat Ito", "Luca", "Développeur");
            Collaborateur.collaborateurList.Add(c);
        }

        private void collaborateurStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cv == null)
            {
                cv = new CollaborateurList();
                cv.FormClosing += new FormClosingEventHandler(this.collobarateurViewClosing);
                cv.MdiParent = this;
                cv.Show();
            }
            if(cv.WindowState == FormWindowState.Minimized)
            {
                cv.WindowState = FormWindowState.Normal;
            }
            else
            {
                cv.Activate();
            }

        }

        private void savingCollaborateur(Collaborateur collaborateur)
        {
            Console.WriteLine("dans saving collaborateur de mainapp : " + collaborateur );
        }

        private void collobarateurViewClosing(object sender, FormClosingEventArgs e)
        {
            cv = null;
        }

    }
}
