using Lab23Breakout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab23Breakout.Controllers
{
    public class HomeController : Controller
    {
        ShopDbEntities db = new ShopDbEntities();
        public ActionResult Index()
        {
            //var user = Session["LoggedInUser"];

            //List<User> p = (List<User>)user;
            //User u = p[0];

            //ViewBag.User = u; 

            User u = (User) Session["LoggedInUser"];

            ViewBag.User = u;

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

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult MakeNewUser(User u)
        {
            db.Users.Add(u);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string UserName, string Password)
        {
            List<User> Users = db.Users.ToList();

            //var output = Users
            //    .Where(u => 
            //    u.UserName == UserName && 
            //    u.Password == Password);

            foreach(User u in Users)
            {
                if(u.UserName == UserName && u.Password == Password)
                {
                    Session["LoggedInUser"] = u;
                }
            }

            return RedirectToAction("Index");
        }
    }
}