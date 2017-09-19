using ABICommercialProject.View;
using ABIModel;
using System;

namespace ABICommercialProject.Controller
{
    public class CtrlEditCollaborateur
    {
        private Collaborateur collaborateur;
        private CollaborateurForm collaborateurForm;
        private Collaborateur c;

        public CollaboHandler UpdatingCollabo;

		public CtrlEditCollaborateur(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            c = (Collaborateur)collaborateur.Clone();
            this.collaborateurForm = new CollaborateurForm(true);
            this.collaborateurForm.SetCollaborateur(collaborateur);
            collaborateurForm.UpdatingCollabo += new EventHandler(this.OnUpdatedCollabo);
        }
        
        private void OnUpdatedCollabo(object sender, EventArgs e)
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
                collaborateur.Name = c.Name;
                collaborateur.Firstname = c.Firstname;
                collaborateur.Address = c.Address;
                collaborateur.Email = c.Email;
                collaborateur.Statut = c.Statut;
                collaborateur.Tel = c.Tel;
                collaborateur.Town = c.Town;
                collaborateur.ZipCode = c.ZipCode;
                collaborateur.FonctionCollabo = c.FonctionCollabo;
                collaborateurForm.SetCollaborateur(c);
                collaborateurForm.DisplayErrorMessage(ex.Message, "Exception Updating Collaborateur");

            }
        }

        public void Init()
        {
            collaborateurForm.DisplayDialog();
        }
    }
}
