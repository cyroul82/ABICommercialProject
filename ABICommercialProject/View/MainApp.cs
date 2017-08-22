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
            Console.WriteLine(c);
        }

        private void collaborateurStripMenuItem_Click(object sender, EventArgs e)
        {
            CollaborateurView cv = new CollaborateurView();
            cv.MdiParent = this;
            cv.Show();
        }
    }
}
