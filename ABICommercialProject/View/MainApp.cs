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
    public delegate void SavingCollaborateur(Collaborateur collaborateur, Contrat contrat); 
    public partial class MainApp : Form
    {
        public static MainApp instance;

        private CollaborateurList cv;
        private MainApp()
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

        public static MainApp Instance()
        {
            if(instance == null)
            {
                instance = new MainApp();
            }
            return instance;
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


        private void collobarateurViewClosing(object sender, FormClosingEventArgs e)
        {
            cv = null;
        }
    }
}
