using APIBreakout.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace APIBreakout.Controllers
{
    public class HomeController : Controller
    {
        public string GetData()
        {
            string URL = "https://swapi.co/api/people/1/";

            HttpWebRequest request = WebRequest.CreateHttp(URL);
            //If we needed it, special setup would go here

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string APIText = rd.ReadToEnd();

            return APIText;
        }

        public Person ConvertToPerson(string APIText)
        {
            JToken t = JToken.Parse(APIText);
            Person p = new Person();
            p.Name = t["name"].ToString();
            p.SkinColor = t["skin_color"].ToString();
            p.HomeWorld = t["homeworld"].ToString();
            List<string> filmEndpoints = new List<string>();
            List<JToken> jtokens=  t["films"].ToList();

            foreach(JToken j in jtokens)
            {
                string filmEndpoint = j.ToString();
                filmEndpoints.Add(filmEndpoint);
            }

            p.Films = filmEndpoints;

            return p;
        }

        public ActionResult Index()
        {
            string APIText = GetData();
            Person p = ConvertToPerson(APIText);

            ViewBag.APIOutput = APIText;

            return View(p);
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