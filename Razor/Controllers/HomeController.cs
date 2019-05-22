using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
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

        public ActionResult People()
        {
            return View();
        }

        public ActionResult Product()
        {
            List<Product> outputs = GetProducts();
            return View(outputs);
        }
        public ActionResult ProductDisplay()
        {
            List<Product> outputs = GetProducts();
            return View(outputs);
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            Product p = new Product("Squeegee",3.50,"It let's wipe off that water!");
            products.Add(p);
            p = new Product("Bucket",7.99,"Holds Water");
            products.Add(p);
            p = new Product("Monkey Bread", 0, "Cinnamon delicious bread");
            products.Add(p);
            p = new Product("Cereal", 4, "It's whole wheat!");
            products.Add(p);
            

            //How would we add in a new product, how would we do that?

            return products;
        }
    }
}