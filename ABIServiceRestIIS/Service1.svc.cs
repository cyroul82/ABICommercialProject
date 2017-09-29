using ABIDAO;
using ABIModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ABIServiceRestIIS
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }


        public Collaborateur GetCollaborateur(string idCollabo)
        {
            try
            {
                return DAO.getInstance().GetCollaborateur(Convert.ToInt32(idCollabo));
            }
            catch(Exception e)
            {
                return new Collaborateur("nomcyril", "prenom", "fonction", e.Message.ToString(), "zip", "town", "tel", "email");
            }
        }

        public IList<Collaborateur> GetCollaborateurs()
        {
            return DAO.getInstance().GetCollabos();
        }
    }
}
