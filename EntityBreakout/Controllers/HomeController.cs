using EntityBreakout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityBreakout.Controllers
{
    public class HomeController : Controller
    {
        //reference to the database 
        StarWarsEntities db = new StarWarsEntities();

        public ActionResult Index()
        {
            List<Person> p = db.People.ToList();
            Person output = p[0];
            ViewBag.Person = output;
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