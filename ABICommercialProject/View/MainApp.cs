using ABICommercialProject.Controller;
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
        private static MainApp instance;
        internal CtrlListCollaborateur ctrl;
        private MainApp()
        {
            InitializeComponent();
        }

        public static MainApp getInstance()
        {
            if(instance == null)
            {
                instance = new MainApp();
            }
            return instance;
        }

        private void collaborateurStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ctrl == null)
            {
                ctrl = new CtrlListCollaborateur();
                
            }
            else
            {
                ctrl.display();
            }
            

        }
    }
}
