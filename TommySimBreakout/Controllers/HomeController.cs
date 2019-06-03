using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TommySimBreakout.Models;

namespace TommySimBreakout.Controllers
{
    public class HomeController : Controller
    {
        TommySimSavesEntities db = new TommySimSavesEntities();

        public ActionResult Index()
        {
            Session["GameId"] = 1; 
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

        public ActionResult Game()
        {
            int id = (int) Session["GameId"];
            ViewBag.CityId = id;
            City c = db.Cities.Find(id);

            return View(c);
        }

        public ActionResult Harvest(string resource)
        {
            Random r = new Random();
            City c = db.Cities.Find(1);
            if (c.Actions > 0) {
                c.Actions--;
                if (resource.ToLower() == "water")
                {
                    c.Water += r.Next(1,6);
                }
            }

            db.Cities.AddOrUpdate(c);

            db.SaveChanges();

            return RedirectToAction("Game");
        }
    }
}