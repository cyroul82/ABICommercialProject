using ABIModel;
using ABIWebsite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ABIWebsite.Controllers
{
    public class CollaborateurController : Controller
    {
        // GET: List of Collaborateur
        string Baseurl = "http://griffin:10000/";

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
            List<Contrat> contrats = new List<Contrat>();
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

                string ss = "/Service1.svc/rest/collabo/contrats/" + id;
                HttpResponseMessage Response = await client.GetAsync(ss);

                if (Response.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var ContResponse = Response.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list  
                    List<RootObject> r = JsonConvert.DeserializeObject<List<RootObject>>(ContResponse);
                    foreach(RootObject ro in r){
                        if(ro.__type == "Cdi:#ABIModel")
                        {
                            Contrat c = new Cdi
                            {
                                Cloture = ro.Cloture,
                                DateDebutContrat = ro.DateDebutContrat,
                                DateFinEffectif = ro.DateFinEffectif,
                                Id = ro.Id,
                                MotifCloture = ro.MotifCloture,
                                Qualification = ro.Qualification,
                                SalaireBrut = Convert.ToDecimal(ro.SalaireBrut),
                                StatutContrat = Statut.Cadre
                            };
                            contrats.Add(c);
                        }
                    }
                    

                }

                collaborateur.Contrats = new HashSet<Contrat>();
                foreach(Contrat c in contrats)
                {
                    collaborateur.Contrats.Add(c);
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
        public ActionResult UpdateCollaborateur(Collaborateur collaborateur)
        {
            try
            {
                WebClient WC = new WebClient();
                WC.Headers.Add("Content-Type", "application/json");
                WC.Encoding = Encoding.UTF8;

                MemoryStream MS = new MemoryStream();
                DataContractJsonSerializer JSrz = new
                DataContractJsonSerializer(typeof(Collaborateur));
                JSrz.WriteObject(MS, collaborateur);
                string data = Encoding.UTF8.GetString(MS.ToArray(), 0, (int)MS.Length);

                byte[] res1 =
                WC.UploadData("http://griffin:10000/Service1.svc/rest/update/", "POST", MS.ToArray());

                MS = new MemoryStream(res1);
                JSrz = new DataContractJsonSerializer(typeof(int));
                int result = (int)JSrz.ReadObject(MS);
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