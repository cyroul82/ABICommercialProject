using ABIModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ABIDAO
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ICollaborateurService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ICollaborateurService
    {
        [OperationContract]
        List<Collaborateur> ListCollaborateur();
    }
}
