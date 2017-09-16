using ABICommercialProject.Model;
using ABICommercialProject.View;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABICommercialProject.Controller
{
    public class CtrlEditCollaborateur
    {
        private Collaborateur collaborateur;
        private Collaborateur oldOollaborateur;
        private CollaborateurForm collaborateurForm;

        public CollaboHandler UpdatingCollabo;
		public CtrlEditCollaborateur(ref Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            this.oldOollaborateur = collaborateur;
            this.collaborateurForm = new CollaborateurForm(collaborateur, true);
            collaborateurForm.UpdatingCollabo += new EventHandler(this.onUpdatedCollabo);
        }
        
        private void onUpdatedCollabo(object sender, EventArgs e)
        {
            try
            {
                DAOToChange.getInstance().Update();
                collaborateurForm.CloseDialog();
                UpdatingCollabo?.Invoke(collaborateur);
            }
            //catch(ArgumentNullException ae)
            //{
            //    collaborateurForm.displayErrorMessage(ae.Message, "ArgumentNullException Updating Collaborateur");

            //}
            //catch(InvalidOperationException ie)
            //{
            //    collaborateurForm.displayErrorMessage(ie.InnerException.Message, "InvalidOperationException Updating Collaborateur");

            //}
            //catch(DbUpdateException)
            //{
            //    collaborateurForm.displayErrorMessage("Nom et prénom déjà existant", "DbUpdateException Updating Collaborateur");

            //}
            catch (Exception ex)
            {
                collaborateurForm.SetCollaborateur(oldOollaborateur);
                collaborateurForm.DisplayErrorMessage(ex.Message, "Exception Updating Collaborateur");

            }
        }

        public void init()
        {
            collaborateurForm.DisplayDialog();
        }
    }
}
