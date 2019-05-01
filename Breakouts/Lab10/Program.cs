using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Cyan;
            Circle c = new Circle(5.5);
            Console.WriteLine("Circumference: " + c.GetCircumference() );
            Console.WriteLine("Area: " + c.GetArea());
            Console.WriteLine("-------------");

            Circle c2 = new Circle(120.16);
            c2.PrintInfo();

            //Circle doesn't exist how do we fix this error!
            CircleAPP ca = new CircleAPP();

            ca.Run();
        }
    }
}
