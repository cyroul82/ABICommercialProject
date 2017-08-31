using ABICommercialProject.Model;
using ABICommercialProject.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABICommercialProject.Controller
{
    public delegate void SavedCollaboHandler(Collaborateur collabo);
    public class CtrlNewCollaborateur
    {
        public SavedCollaboHandler onSavedCollabo;

        private CollaborateurForm collaborateurForm;
        public CtrlNewCollaborateur()
        { 
            this.collaborateurForm = new CollaborateurForm();
           
            collaborateurForm.onSaved += new ActionClickSave(this.savingCollabo);
            collaborateurForm.displayDialog();
        }

        private void savingCollabo(String message)
        {
            Console.WriteLine("dans saving collabo ctrlNEw");
            if (message == Tools.save)
            {
                Console.WriteLine("dans saving collabo ctrlNEw");
                Contrat contrat = collaborateurForm.getContrat();
                Collaborateur collaborateur = collaborateurForm.getCollaborateur();


                if (contrat != null && collaborateur != null)
                {
                    collaborateur.AddContrat(contrat);
                    collaborateur.setContratActif(contrat);
                    collaborateur.Statut = true;
                    collaborateur.Matricule = MainApp.matricule++;
                    onSavedCollabo(collaborateur);
                    collaborateurForm.closeDialog();
                }
                else
                {
                    collaborateurForm.displayMessageBox("Unexpected Error, Contrat or Collaborateur is null", "Error App", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
