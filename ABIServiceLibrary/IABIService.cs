using ABIModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ABIServiceLibrary
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IABIService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IABIService
    {
        [OperationContract]
        Collaborateur GetCollaborateur(int idCollabo);

        [OperationContract]
        IList<Collaborateur> GetCollaborateurList();

        [OperationContract]
        void UpdateCollabo(Collaborateur collabo);

        [OperationContract]
        string getName();
    }
}
