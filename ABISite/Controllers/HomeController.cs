using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ABISite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var url = "http://bip14:10000/Service1.svc/rest/collabo/1";
            //var webRequest = (HttpWebRequest)System.Net.WebRequest.Create(url);
            //using (var response = webRequest.GetResponse())
            //{
            //    using (var reader = new StreamReader(response.GetResponseStream()))
            //    {
            //        var result = reader.ReadToEnd();
            //        var d = JsonConvert.DeserializeObject(result);

            //        Console.WriteLine("Result : " + d);

            //    }
            //}


            //Get method

            WebRequest req = WebRequest.Create(@"http://bip14:10000/Service1.svc/rest/collabo/1");

            req.Method = "GET";

            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            if (resp.StatusCode == HttpStatusCode.OK)
            {
                using (Stream respStream = resp.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(respStream, Encoding.UTF8);
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            else
            {
                Console.WriteLine(string.Format("Status Code: {0}, Status Description: {1}", resp.StatusCode, resp.StatusDescription));
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}