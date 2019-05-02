using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Circle
    {
        //private double radius;
        public double Radius { get; set; }
        private string password; 
        public string Password { get { return password; } set { password = value; } }

        public Circle(double r)
        {
            //this.Radius = Radius;
            Radius = r;
        }
    }
}
