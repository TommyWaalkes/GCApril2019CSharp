using Lab23Breakout.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
                    break;
                }
            }

            return RedirectToAction("Index");
        }

        //public ActionResult Buy(int id)
        //{
        //    if (Session["LoggedInUser"] != null)
        //    {
        //        Item purchase = db.Items.Find(id);
        //        User buyer = (User) Session["LoggedInUser"];
        //        if(buyer.Money < purchase.Price)
        //        {
        //            Session["Error"] = $"{buyer.UserName} cannot afford {purchase.ProductName} at ${purchase.Price}";
        //        }
        //        else
        //        {
        //            buyer.Money -= purchase.Price;
        //            db.Users.AddOrUpdate(buyer);
        //            db.SaveChanges();
        //        }
        //    }

        //    return RedirectToAction("Index");
        //}

        public ActionResult Buy(int id)
        {
            Item purchase = db.Items.Find(id);
            if (Session["LoggedInUser"] != null)
            {
                User buyer = (User)Session["LoggedInUser"];

                if (buyer.Money > purchase.Price && purchase.Quantity > 0)
                {
                    buyer.Money -= purchase.Price;
                    purchase.Quantity--;
                    db.Users.AddOrUpdate(buyer);
                    db.Items.AddOrUpdate(purchase);

                    db.SaveChanges();
                }
            }
            else
            {
                Session["Error"] = "You must login before you make a purchase";
                return RedirectToAction("Login");
            }
            return RedirectToAction("Shop");
        }

        public ActionResult Shop()
        {
            List<Item> products = db.Items.ToList();

            return View(products);
        }
    }
}