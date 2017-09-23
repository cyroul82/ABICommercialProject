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
            mainApp.OpeningCollaborateur += new EventHandler(this.OpeningCollabo);
        }

        public static CtrlMain GetInstance()
        {
            if (ctrlMain == null)
            {
                ctrlMain = new CtrlMain();
            }
            return ctrlMain;
        }

        public MDIParent GetMainApp()
        {
            return mainApp;
        }

        private void OpeningCollabo(object sender, EventArgs e)
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

        
        public void CloseCtrlListCollaborateur()
        {
            ctrlListCollaborateur = null;
        }


        

    }
}
