using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLabBreakout
{
    class Program
    {
        static void Main(string[] args)
        {
            Country c = new Country();
            c.Name = "Rome";
            c.Continent = "Europe";
            c.Colors = new List<string>() {"Red", "Purple", "Gold" };

            Country c2 = new Country();
            c2.Name = "Mongolia";
            c2.Continent = "Asia";
            c2.Colors = new List<string>() { "Red", "Blue", "Yellow" };

            Country c3 = new Country();
            c3.Name = "Republic of Korea";
            c3.Continent = "Asia";
            c3.Colors = new List<string>() { "White","Black", "Red", "Blue" };

            List<Country> countries = new List<Country>() {c,c2,c3 };
            //CountryListView listView = new CountryListView(countries);

            //listView.Display();

            Controller con = new Controller(countries);
            con.AddCountry();
            con.WelcomeAction();
        }
    }
}
