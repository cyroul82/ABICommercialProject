﻿using ABIModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ABIServiceRestIIS
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate = "bouboul/{value}")]
        string GetData(string value);

        [OperationContract]
        [WebGet(UriTemplate = "collabo/{idCollabo}")]
        Collaborateur GetCollaborateur(string idCollabo);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "collabos")]
        IList<Collaborateur> GetCollaborateurs();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "collabo/contrats/{idCollabo}")]
        IList<Contrat> GetContratCollaborateur(string idCollabo);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "update", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        int UpdateCollabo(Collaborateur collaborateur);
    }


    
    
}
