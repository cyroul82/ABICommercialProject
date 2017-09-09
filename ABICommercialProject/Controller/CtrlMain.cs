﻿using ABICommercialProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABICommercialProject.Controller
{
    public class CtrlMain
    {
        private static CtrlMain ctrlMain;
        private MDIParent mainApp;
        private CtrlListCollaborateur ctrlListCollaborateur;
        private CtrlMain()
        {
            mainApp = new MDIParent();
            mainApp.OpeningCollaborateur += new EventHandler(this.openingCollabo);
        }

        private void openingCollabo(object sender, EventArgs e)
        {
            if (ctrlListCollaborateur == null)
            {
                try
                {
                    ctrlListCollaborateur = new CtrlListCollaborateur();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                ctrlListCollaborateur.display();
            }
        }

        public void closeCtrlListCollaborateur()
        {
            ctrlListCollaborateur = null;
        }

        public static CtrlMain getInstance()
        {
            if(ctrlMain == null)
            {
                ctrlMain = new CtrlMain();
            }
            return ctrlMain;
        }

        public MDIParent getMainApp()
        {
            return mainApp;
        }
    }
}