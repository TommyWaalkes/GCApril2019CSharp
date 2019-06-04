using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieDbBreakout.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Plot { get; set; }
        public string PosterURL { get; set; }
    }
}