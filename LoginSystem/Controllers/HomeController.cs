using LoginSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginSystem.Controllers
{
    public class HomeController : Controller
    {
        public List<User> Users {
            get
            {
                if (Users == null)
                {
                    Users = new List<User>();
                }
                return Users;
            }, 

            set;
        }

        //The first overload is for rendering the view
        public ActionResult Registration()
        {
           
            return View();
        }

        //Processing the form submission
        [HttpPost]
        public ActionResult Registration(User u)
        {
            Users.Add(u);
            return RedirectToAction("Login");
        }

        //This displays our view
        public ActionResult Login()
        {
            ViewBag.Count = Users.Count;
            return View();
        }

        [HttpPost]
        public ActionResult Login(User u)
        {
            var v = "1";
            foreach(User us in Users)
            {
                //If they match store the user in a session
                if(u.UserName == us.UserName && u.Password == us.Password)
                {
                    Session["CurrentUser"] = us;
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Error = "The username and password don't match";
            return View();
        }

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
    }
}