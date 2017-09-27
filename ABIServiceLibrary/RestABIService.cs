using ABIDAO;
using ABIModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIServiceLibrary
{
    public class RestABIService : IRestABIService
    {
        public string EchoWithGet(string s)
        {
            return "Get said " + s;
        }

        public string EchoWithPost(string s)
        {
            return "Post said " + s;
        }

        public Collaborateur GetCollaborateur(string idCollabo)
        {

            return DAO.getInstance().GetCollaborateur(Convert.ToInt32(idCollabo));
        }
    }
}
