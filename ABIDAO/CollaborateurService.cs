using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ABIModel;

namespace ABIDAO
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CollaborateurService" à la fois dans le code et le fichier de configuration.
    public class CollaborateurService : ICollaborateurService
    {
        public List<Collaborateur> ListCollaborateur()
        {
            throw new NotImplementedException();
        }
    }
}
