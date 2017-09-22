using ABIDAO;
using ABIModel;
using ABIView;
using System;

namespace ABIController
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
                collaborateurForm.CloseDialog();
                UpdatingCollabo?.Invoke(collaborateur);
            }
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
