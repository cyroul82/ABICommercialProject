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
    public delegate void SaveCollaboHandler(Collaborateur collabo);
    public class CtrlNewCollaborateur
    {
        public SaveCollaboHandler onSaveCollabo;
        private CollaborateurForm collaborateurForm;
        public CtrlNewCollaborateur()
        { 
            this.collaborateurForm = new CollaborateurForm();
           
            collaborateurForm.clickEvent += new ClickHandler(this.clickEvent);
            collaborateurForm.displayDialog();
        }

        private void clickEvent(String message)
        {
            if (message == Tools.save)
            {
                Contrat contrat = collaborateurForm.getContrat();
                Collaborateur collaborateur = collaborateurForm.getCollaborateur();


                if (contrat != null && collaborateur != null)
                {
                    onSaveCollabo?.Invoke(collaborateur);
                    //savingCollaborateur(collaborateur, contrat);
                    collaborateurForm.closeDialog();
                }
                else
                {
                    collaborateurForm.displayMessageBox("Unexpected Error, Contrat or Collaborateur is null", "Error App", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }


        private void savingCollaborateur(Collaborateur collaborateur, Contrat contrat)
        {
            //this.addCollaborateur(collaborateur);


        }

        //private void addCollaborateur(Collaborateur collaborateur)
        //{
        //    DataRow dr = dt.NewRow();
        //    dr["Matricule"] = collaborateur.Matricule;
        //    dr["Nom"] = collaborateur.NomCollabo;
        //    dr["Prénom"] = collaborateur.PrenomCollabo;
        //    dr["Fonction"] = collaborateur.FonctionCollabo;
        //    dt.Rows.Add(dr);
        //}



    }


}
