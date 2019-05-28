using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerValidationExample.Controllers
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

        public ActionResult Login(string UserName, int Age)
        {
            if(Age >=0 && Age <= 120)
            {
                return RedirectToAction("About");
            }
            else
            {
                return RedirectToAction("Contact");
            }
        }
    }
}