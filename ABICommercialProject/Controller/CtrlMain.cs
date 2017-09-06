using ABICommercialProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABICommercialProject.Controller
{
    public class CtrlMain
    {
        private static CtrlMain instance;
        internal CtrlListCollaborateur ctrlListCollaborateur;
        public static Int32 matricule = 0;
        private MainForm mainForm;
        public SortedDictionary<Int32, Collaborateur> collaborateurList = new SortedDictionary<int, Collaborateur>();



        private CtrlMain()
        {
            this.mainForm = new MainForm();
            this.mainForm.OpeningCollaborateur += new EventHandler(this.OpeningCollaborateur);
        }

        public static CtrlMain getInstance()
        {
            if (instance == null)
            {
                instance = new CtrlMain();
            }
            return instance;
        }

        public MainForm getMainForm()
        {
            return mainForm;
        }

        private void OpeningCollaborateur(object sender, EventArgs e)
        {
            if (ctrlListCollaborateur == null)
            {
                ctrlListCollaborateur = new CtrlListCollaborateur(ref collaborateurList);

            }
            else
            {
                ctrlListCollaborateur.display();
            }
        }
        
        public void updateView()
        {
            ctrlListCollaborateur.update();
        }        


    }
}
