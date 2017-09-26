using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ABIModel;
using ABIDAO;

namespace ABIServiceLibrary
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ABIService" à la fois dans le code et le fichier de configuration.
    public class ABIService : IABIService
    {
        public Collaborateur GetCollaborateur(int idCollabo)
        {
            return DAO.getInstance().GetCollaborateur(idCollabo);
        }

        public string getName()
        {
            return "salut";
        }

        public IList<Collaborateur> GetCollaborateurList()
        {
            IList<Collaborateur> c = DAO.getInstance().GetCollabos();
            return c;
        }

        public void UpdateCollabo(Collaborateur collabo)
        {
            throw new NotImplementedException();
        }
    }
}
