using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroToNet.Models;

namespace IntroToNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Goat()
        {

            return View();

        }

        public ActionResult Result(Person inputPerson)
        {
            if(inputPerson.firstName =="" || inputPerson.firstName == null)
            {
                Session["Error"] = "The first name field was empty, please enter a name";
                return RedirectToAction("Contact");
            }

            ViewBag.Name = inputPerson.firstName;
            ViewBag.Age = inputPerson.age;

            return View();
        }
    }
}