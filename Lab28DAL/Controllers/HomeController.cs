using Lab28DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab28DAL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CardList()
        {
            Deck d;
            if (Session["deck"] == null)
            {
                //This is for a new deck
                 d = CardAPIDAL.GetNewDeck();
                Session["deck"] = d;
            }
            else
            {
                //This is if we already have a deck 
                d = (Deck) Session["deck"];
            }

            List<Card> cards = CardAPIDAL.DrawCards(5, d);
            Session["deck"] = CardAPIDAL.UpdateDeck(d);

            return View(cards);
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