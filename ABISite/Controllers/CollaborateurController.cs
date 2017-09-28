using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABISite.Controllers
{
    public class CollaborateurController : Controller
    {
        // GET: Collaborateur
        public ActionResult Index(string idCollabo)
        {
            return View();
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
    }
}
