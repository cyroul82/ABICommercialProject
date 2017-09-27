using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ABIServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ABIServiceLibrary.ABIService)))
            {
                host.Open();
                Console.WriteLine("Server started");
                Console.ReadLine();
            }
        }
    }
}
