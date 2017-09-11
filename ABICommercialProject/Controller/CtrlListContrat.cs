﻿using ABICommercialProject.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABICommercialProject.Controller
{
    public class CtrlListContrat
    {
        private ContratListForm contratListForm;
        private Collaborateur collaborateur;

        public EventHandler Refreshing;
        public CtrlListContrat(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            contratListForm = new ContratListForm(collaborateur);
            contratListForm.CloturingContrat += new ContratHandler(this.onCloturedContrat);
            contratListForm.CreatingContrat += new EventHandler(this.onCreatedContrat);
            contratListForm.SelectingContrat += new SelectingHandler(this.onSelectedContrat);
            
        }
        public CtrlListContrat(Collaborateur collaborateur, CollaborateurForm clf)
        {
            this.collaborateur = collaborateur;
            contratListForm = new ContratListForm(collaborateur);
            contratListForm.FormBorderStyle = FormBorderStyle.None;
            contratListForm.TopLevel = false;
            contratListForm.AutoScroll = true;
            clf.panelContrat.Controls.Add(contratListForm);
            contratListForm.Show();
            contratListForm.CloturingContrat += new ContratHandler(this.onCloturedContrat);
            contratListForm.CreatingContrat += new EventHandler(this.onCreatedContrat);
            contratListForm.SelectingContrat += new SelectingHandler(this.onSelectedContrat);

        }
                

        public void init()
        {
            if (contratListForm != null)
            {
                contratListForm.ShowDialog();
            }
        }

        private void onSelectedContrat(int id)
        {
            if (collaborateur.getListContrat().ContainsKey(id))
            {
                CtrlViewContrat ctrlViewContrat = new CtrlViewContrat(collaborateur.getListContrat()[id]);
                ctrlViewContrat.CloturingContrat += new ContratHandler(this.onCloturedContrat);
                ctrlViewContrat.init();
            }
        }

        private void onCreatedContrat(object sender, EventArgs e)
        {
            if (!collaborateur.hasContratActif())
            {
                CtrlNewContrat ctrlNewContrat = new CtrlNewContrat(collaborateur);
                ctrlNewContrat.SavingContrat += new ContratHandler(this.onSavedContrat);
                ctrlNewContrat.init();
            }
            else
            {
                MessageBox.Show("Contrat actif déja existant, clôturer le contrat actif", "Erreur Contrat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void onSavedContrat(Contrat contrat)
        {
            if (contrat != null)
            {
                Random r = new Random();
                Int32 i = r.Next(1001, 10000);
                contrat.NumeroContrat = i;
                collaborateur.getListContrat().Add(contrat.NumeroContrat, contrat);
                collaborateur.setContratActif(contrat);
                refresh();
            }
        }

        private void onCloturedContrat(Contrat contrat)
        {
            if(contrat == collaborateur.getContratActif())
            {
                collaborateur.setContratActif(null);
                collaborateur.getListContrat()[contrat.NumeroContrat] = contrat;
                refresh();
            }
        }

        private void refresh()
        {
            contratListForm.setDataSource();
            Refreshing?.Invoke(this, null);
        }
    }
}
