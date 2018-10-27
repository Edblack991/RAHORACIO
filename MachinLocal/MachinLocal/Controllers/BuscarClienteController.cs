using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MachinLocal.Controllers
{
    public class BuscarClienteController : Controller
    {
        // GET: BuscarCliente
        public ActionResult Index()
        {
            return View();
        }

        // GET: BuscarCliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BuscarCliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BuscarCliente/Create
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

        // GET: BuscarCliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BuscarCliente/Edit/5
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

        // GET: BuscarCliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BuscarCliente/Delete/5
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
