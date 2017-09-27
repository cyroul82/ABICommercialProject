using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using ABIServiceLibrary;

namespace ABIRestServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {

            using (WebServiceHost host = new WebServiceHost(typeof(RestABIService), new Uri("http://localhost:8000/")))
            {
                ServiceEndpoint ep = host.AddServiceEndpoint(typeof(IRestABIService), new WebHttpBinding(), "");
                

                host.Open();
                Console.WriteLine("Service REST is running");
                Console.WriteLine("Press enter to quit...");
                Console.ReadLine();


            }
        }
    }
}
