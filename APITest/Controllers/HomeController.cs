using APITest.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace APITest.Controllers
{
    public class HomeController : Controller
    {//This is in it's own method for consistency and reusuability 
        public string GetPerson(int id)
        {
            string url = "https://swapi.co/api/people/1/";
            HttpWebRequest request = WebRequest.CreateHttp(url);

            //request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());
            string apiText = rd.ReadToEnd();

            return apiText;
        }

        public Person APITextToPerson(string text)
        {
            //This converts our string into the JSON format, which we can use 
            //to dig through and organize the larger string
            JToken t = JToken.Parse(text);
            Person p = new Person();
            p.Name = t["name"].ToString();
            p.HomePlanet = t["homeworld"].ToString();
            p.URL = t["url"].ToString();

            return p;
        }

        public ActionResult Index()
        {
            string text = GetPerson(1);
            Person p = APITextToPerson(text);
            ViewBag.APIText = text;

            ViewBag.Person = p;
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