using MachinLocal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MachinLocal.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            using (MachinLocalDbContext Db = new MachinLocalDbContext())
            {
                new MachinLocalDbInitializer().InitializeDatabase(Db);
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