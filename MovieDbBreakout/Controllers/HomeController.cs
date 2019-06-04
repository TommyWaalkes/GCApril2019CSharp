using MovieDbBreakout.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MovieDbBreakout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string title)
        {

            string APIText = GetAPIText(title);
            Movie mov = ConvertToMovie(APIText);

            return View(mov);
        }

        public ActionResult MovieList(string title)
        {
            string APIText = GetListMovies(title);
            List<Movie> movies = ConvertListOfMovies(APIText);

            return View(movies);
        }

        public string GetAPIText(string title)
        {
            string APIkey = "62398519";
            string URL = $"http://www.omdbapi.com/?apikey={APIkey}&&t={title}";

            HttpWebRequest request = WebRequest.CreateHttp(URL);

            //There will sometimes be extra steps here between request and response

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string APIText = rd.ReadToEnd();

            return APIText;
        }

        public string GetListMovies(string title)
        {
            string APIkey = "62398519";
            string URL = $"http://www.omdbapi.com/?apikey={APIkey}&&s={title}";

            HttpWebRequest request = WebRequest.CreateHttp(URL);

            //There will sometimes be extra steps here between request and response

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string APIText = rd.ReadToEnd();

            return APIText;
        }

        public Movie ConvertToMovie(string APIText)
        {
           JToken jsonData =  JToken.Parse(APIText);
            Movie m = new Movie();
            m.Title = jsonData["Title"].ToString();
            m.Plot = jsonData["Plot"].ToString();
            m.PosterURL = jsonData["Poster"].ToString();
            return m;
        }

        public List<Movie> ConvertListOfMovies(string APIText)
        {
            JToken json = JToken.Parse(APIText);

            List<JToken> filmTokens = json["Search"].ToList();

            List<Movie> MovieResults = new List<Movie>();

            foreach(JToken j in filmTokens)
            {
                //Make a movie and grab out the json data
                Movie m = new Movie();
                m.Title = j["Title"].ToString();
                MovieResults.Add(m);
            }

            return MovieResults;
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