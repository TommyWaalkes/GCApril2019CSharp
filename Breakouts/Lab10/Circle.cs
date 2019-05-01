using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        private double radius;

        public Circle(double r)
        {
            //this.radius = radius;
            radius = r;
        }

        public double GetCircumference()
        {
            double output = Math.Floor(2 * Math.PI * radius);
            return output; 
        }

        public double GetArea()
        {
            double area = Math.Floor(Math.PI * Math.Pow(radius, 2));
            return area; 
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Area: { GetArea() }");
            Console.WriteLine($"Circumference: { GetCircumference() }");
        }
       
    }
}
