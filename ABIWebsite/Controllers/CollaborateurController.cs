using ABIModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ABIWebsite.Controllers
{
    public class CollaborateurController : Controller
    {
        // GET: List of Collaborateur
        string Baseurl = "http://BIP14:10000/";

        public async Task<ActionResult> Index()
        {
            List<Collaborateur> EmpInfo = new List<Collaborateur>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("/Service1.svc/rest/collabos");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    EmpInfo = JsonConvert.DeserializeObject<List<Collaborateur>>(EmpResponse);

                }
                //returning the employee list to view  
                return View(EmpInfo);
            }
        }

        public async Task<ActionResult> Detail(int? id)
        {
            Collaborateur collaborateur = null;
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                string s = "/Service1.svc/rest/collabo/" + id;
                HttpResponseMessage Res = await client.GetAsync(s);
                Console.WriteLine("Res : " + Res);
                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    Console.WriteLine("EmpResponse : " + EmpResponse);
                    //Deserializing the response recieved from web api and storing into the Employee list  
                    collaborateur = JsonConvert.DeserializeObject<Collaborateur>(EmpResponse);

                }
                //returning the employee list to view  
                return View(collaborateur);
            }
        }

        public async Task<ActionResult> Edit(int? id)
        {
            Collaborateur collaborateur = null;
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                string s = "/Service1.svc/rest/collabo/" + id;
                HttpResponseMessage Res = await client.GetAsync(s);
                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list  
                    collaborateur = JsonConvert.DeserializeObject<Collaborateur>(EmpResponse);

                }
                //returning the employee list to view  
                return View(collaborateur);
            }
        }

        [HttpPost]
        public ActionResult UpdateCollaborateur(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}