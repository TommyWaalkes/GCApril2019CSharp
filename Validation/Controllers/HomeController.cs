using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validation.Models;

namespace Validation.Controllers
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

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Success(Car c)
        {
            return View();
        }

        public ActionResult Makes()
        {
            return View();
        }

        public ActionResult Car(Car c)
        {
            List<string> AcceptibleMakes = new List<string>() { "toyota", "ford", "volkswagon" };
            List<string> AcceptibleColors = new List<string>() { "red", "white", "blue"};

                try
                {
                    bool goodMake = AcceptibleMakes.Contains(c.Make.ToLower());
                    bool goodColor = AcceptibleColors.Contains(c.Color.ToLower());

                    if (goodMake && goodColor)
                    {
                        ViewBag.Make = c.Make;
                        ViewBag.Color = c.Color;
                        ViewBag.Mileage = c.Mileage;
                        ViewBag.IsUsed = c.IsUsed;
                        return View();
                    }
                    else
                    {
                    if (!goodColor)
                    {
                        ViewBag.Error = "You did not input an acceptible color";
                    }
                    if (!goodMake)
                    {
                        ViewBag.Error += " You did not input an acceptible make";
                    }
                    return View();
                    }
                }
                catch(NullReferenceException e)
                {
                    ViewBag.Error = "Car info not filled in, please go to index";
                    ViewBag.StackTrace = e.StackTrace;
                return View();
                }
            }
        }
     
    }
