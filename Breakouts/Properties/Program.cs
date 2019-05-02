using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(20);
            //c.Radius = 10;
            c.Password = "password1";
            Console.WriteLine(c.Password);
        }
    }
}
