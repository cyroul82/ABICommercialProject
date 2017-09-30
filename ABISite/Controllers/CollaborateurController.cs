using ABIModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ABISite.Controllers
{
    public class CollaborateurController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
