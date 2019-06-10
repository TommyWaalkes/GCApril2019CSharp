using MockAssessment7.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MockAssessment7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(int Id)
        {
            string url = $"https://grandcircusco.github.io/demo-apis/donuts/{Id}.json";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string ApiText = rd.ReadToEnd();

            JToken result = JToken.Parse(ApiText);

            Doughnut d = new Doughnut();

            d.Id = int.Parse(result["id"].ToString());
            d.Name = result["name"].ToString();
            d.Calories = int.Parse(result["calories"].ToString());
            if (result["photo"] != null)
            {
                d.PhotoURL = result["photo"].ToString();
            }
            List<JToken> e = result["extras"].ToList();
            if (e != null)
            {
                d.Extras = new List<string>();
                foreach (JToken j in e)
                {
                    d.Extras.Add(j.ToString());
                }
            }

            return View(d);
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