using ABIModel;
using System;
using System.Collections.Generic;

namespace ABICommercialProject
{
    public class DAO
    {
        public static IList<Collaborateur> GetCollaborateurs()
        {
            ABIService.ABIServiceClient client = new ABIService.ABIServiceClient("BasicHttpBinding_IABIService");
            IList<Collaborateur> list = client.GetCollaborateurList();
            client.Close();
            return list;
        }
    }
}