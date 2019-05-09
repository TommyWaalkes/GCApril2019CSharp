using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLabBreakout
{
    class AddCountryView
    {
        public Country Display()
        {
            Console.WriteLine("Create Country View");
            Console.WriteLine("Please input your country's Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please input your country's Continent:");
            string continent = Console.ReadLine();
            Console.WriteLine("Please input one of your country's colors:");
            string color = Console.ReadLine();

            Country c = new Country();
            c.Name = name;
            c.Continent = continent;
            c.Colors = new List<string>();
            c.Colors.Add(color);

            return c;

        }
    }
}
