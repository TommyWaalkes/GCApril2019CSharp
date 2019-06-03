using MockAssessment6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MockAssessment6.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDbEntities db = new EmployeeDbEntities();
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

        public ActionResult Employees()
        {
            List<Employee> es = db.Employees.ToList();
            return View(es);
        }

        public ActionResult RetirementInfo(int id)
        {
            Employee e = db.Employees.Find(id);

            if(e.Age > 60)
            {
                ViewBag.CanRetire = true;
            }
            else
            {
                ViewBag.CanRetire = false;
            }
            double salary = (double)e.Salary;
            ViewBag.Benefits = salary * 0.6;

            return View();
        }
    }
}