using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MachinLocal.Controllers
{
    public class InfoClienteController : Controller
    {
        // GET: InfoCliente
        public ActionResult Index()
        {
            return View();
        }

        // GET: InfoCliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InfoCliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InfoCliente/Create
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

        // GET: InfoCliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InfoCliente/Edit/5
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

        // GET: InfoCliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InfoCliente/Delete/5
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
