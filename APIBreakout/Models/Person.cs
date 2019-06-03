using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBreakout.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string SkinColor { get; set; }
        public string BirthYear { get; set; }
        public string HomeWorld { get; set; }
        public List<string> Films { get; set; }
    }
}