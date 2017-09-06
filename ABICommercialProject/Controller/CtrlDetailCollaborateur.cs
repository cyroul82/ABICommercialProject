using ABICommercialProject.Model;
using ABICommercialProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABICommercialProject.Controller
{
    public class CtrlDetailCollaborateur
    {
        private Collaborateur collaborateur;
        private CollaborateurForm collaborateurForm;
        private ContratListForm contratList;
        private static SortedDictionary<Int32, CollaborateurForm> openedForm = new SortedDictionary<int, CollaborateurForm>();

        public CollaboHandler EditingCollaborateur;
        public ContratHandler CloturingContrat;
        
        public CtrlDetailCollaborateur(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            if (!openedForm.ContainsKey(collaborateur.Matricule))
            {
                this.collaborateurForm = new CollaborateurForm(collaborateur, false);
                collaborateurForm.SavingCollabo += new EventHandler(this.onEditedCollabo);
                collaborateurForm.FormClosing += new FormClosingEventHandler(this.onClosedForm);
                collaborateurForm.ListContrat += new EventHandler(this.onListedContrat);
                collaborateurForm.MdiParent = MainApp.getInstance();

                openedForm.Add(collaborateur.Matricule, collaborateurForm);
            }
            else
            {
                this.collaborateurForm = openedForm[collaborateur.Matricule];

                if (collaborateurForm.WindowState == FormWindowState.Minimized)
                {
                    collaborateurForm.WindowState = FormWindowState.Normal;
                }
                else
                {
                    collaborateurForm.Activate();
                }
            }
        }

        private void onListedContrat(object sender, EventArgs e)
        {
            contratList = new ContratListForm(collaborateur.getListContrat());
            contratList.CloturingContrat += new ContratHandler(this.onCloturedContrat);
            contratList.CreatingContrat += new EventHandler(this.onCreatedContrat);
            contratList.ShowDialog();
        }

        private void onCreatedContrat(object sender, EventArgs e)
        {
            if (collaborateur.hasContratActif())
            {
                MessageBox.Show("Le collaborateur a déjà un contrat actif\nClôturer le contrat actif avant d'ajouter un nouveau contrat");
            }
            else
            {
                contratList.DialogResult = DialogResult.OK;
            }

        }

        public void init()
        {
            collaborateurForm.Show();
        }

        private void onCloturedContrat(Contrat contrat)
        {
            if(contrat != null)
            {
                if(contrat == collaborateur.getContratActif())
                {
                    ClotureForm clotureForm = new ClotureForm(ref contrat);
                    if (clotureForm.ShowDialog() == DialogResult.OK)
                    {
                        collaborateur.setContratActif(null);
                        collaborateur.Statut = false;
                        contratList.setDataSource();
                        CloturingContrat?.Invoke(contrat);
                    }
                }
                else
                {
                    MessageBox.Show("Impossible de cloturer un contrat non actif", "Erreur Cloture", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        }

        private void onClosedForm(object sender, FormClosingEventArgs e)
        {
            if (collaborateur != null)
            {
                openedForm.Remove(collaborateur.Matricule);
            }
        }

        private void onEditedCollabo(object sender, EventArgs e)
        {
            if (collaborateur != null)
            {
                collaborateurForm.Close();
                EditingCollaborateur?.Invoke(collaborateur);
            }
        }
    }
}
