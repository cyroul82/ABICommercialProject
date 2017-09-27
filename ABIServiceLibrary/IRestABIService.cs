using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using ABIModel;

namespace ABIServiceLibrary
{
    [ServiceContract]
    public interface IRestABIService
    {
        [OperationContract]
        [WebGet]
        string EchoWithGet(string s);

        [OperationContract]
        [WebInvoke]
        string EchoWithPost(string s);

        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Xml, 
                   BodyStyle = WebMessageBodyStyle.Wrapped,
                   UriTemplate = "collabo/{idCollabo}")]
        Collaborateur GetCollaborateur(string idCollabo);
    }
}