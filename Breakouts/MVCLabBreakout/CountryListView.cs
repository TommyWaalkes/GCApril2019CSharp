using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLabBreakout
{
    class CountryListView
    {
        public List<Country> DisplayCountries { get; set; }

        public CountryListView(List<Country> DisplayCountries)
        {
            this.DisplayCountries = DisplayCountries;
        }

        public void Display()
        {
            Console.WriteLine("Welcome to our Country App!");
            Console.WriteLine("Here is our list of countries: ");
            for (int i = 0; i < DisplayCountries.Count; i++)
            {
                Country DisplayCountry = DisplayCountries[i];
                Console.WriteLine($"{i}: " + DisplayCountry.Name);
            }
           
        }
    }
}
