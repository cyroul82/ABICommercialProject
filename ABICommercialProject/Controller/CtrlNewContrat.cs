﻿using ABICommercialProject.View;
using ABIModel;
using System;
using System.Windows.Forms;

namespace ABICommercialProject.Controller
{
    public class CtrlNewContrat
    {
        private Collaborateur collaborateur;
        private ContratForm cf;

        public EventHandler SavingContrat;
        public CtrlNewContrat(ref Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            cf = new ContratForm();
            cf.SavingContrat += new ContratHandler(this.onSavedContrat);
        }

        public void init()
        {   if (cf != null)
            {
                cf.ShowDialog();
            }
        }

        private void onSavedContrat(Contrat contrat)
        {
            if (contrat != null)
            {
                try
                {
                    collaborateur.AddContrat(contrat);
                    DAOToChange.getInstance().Update();

                    SavingContrat?.Invoke(this, new EventArgs());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
