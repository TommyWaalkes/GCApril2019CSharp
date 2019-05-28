using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MockAssessment5.Controllers
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

        public ActionResult Calculator()
        {
            return View();
        }

        public ActionResult Result(int num1, int num2, string operation)
        {
            ViewBag.Operation = operation;
            int result = 0;
            if (operation == "Plus")
            {
                result = num1 + num2;
            }
            else if (operation == "Minus")
            {
                result = num1 - num2;
            }
            else if (operation == "Multiply")
            {
                result = num1 * num2;
            }
            else if (operation == "Divide")
            {
                result = num1 / num2;
            }
            ViewBag.Result = result;
            return View();
        }
    }
}