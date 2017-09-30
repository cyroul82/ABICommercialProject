using ABIModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ABISite.Controllers
{
    public class HomeController : Controller
    {
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

                Console.WriteLine(Res);
                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(EmpResponse);

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    EmpInfo = JsonConvert.DeserializeObject<List<Collaborateur>>(EmpResponse);

                }
                //returning the employee list to view  
                return View(EmpInfo);
            }
        }

        // GET: Collaborateur/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Collaborateur/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Collaborateur/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Collaborateur/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Collaborateur/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Collaborateur/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Collaborateur/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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