using ABIModel;
using ABIView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIController
{

    

    public class CtrlMain
    {
        private CtrlListCollaborateur ctrlListCollaborateur;
        private static CtrlMain ctrlMain;
        private MDIParent mainApp;
        private CtrlMain()
        {
            mainApp = new MDIParent();
            mainApp.OpeningCollaborateur += new EventHandler(this.openingCollabo);
        }

        public static CtrlMain getInstance()
        {
            if (ctrlMain == null)
            {
                ctrlMain = new CtrlMain();
            }
            return ctrlMain;
        }

        public MDIParent getMainApp()
        {
            return mainApp;
        }

        private void openingCollabo(object sender, EventArgs e)
        {
            if (ctrlListCollaborateur == null)
            {
              ctrlListCollaborateur = new CtrlListCollaborateur();
            }
            else
            {
                ctrlListCollaborateur.Display();
            }
        }

        
        public void closeCtrlListCollaborateur()
        {
            ctrlListCollaborateur = null;
        }


        

    }
}
