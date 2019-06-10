using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MockAssessment7.Models
{
    public class Doughnut
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public string PhotoURL { get; set; }
        public List<string> Extras { get; set; }
    }
}