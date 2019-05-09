using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLabBreakout
{
    class Controller
    {
        List<Country> CountryDb = new List<Country>();

        public Controller(List<Country> CountryDb)
        {
            this.CountryDb = CountryDb;
        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDb);
            clv.Display();
            string input = Console.ReadLine();
            int index = int.Parse(input);

            Country c = CountryDb[index];

            CountryAction(c);
            
        }

        public void AddCountry()
        {
            //1) Ask the user for input to fill in each property in Country
            //2) Make a Country Model based upon user input
            //3) In the controller, Add the country model to CountryDd
            AddCountryView acd = new AddCountryView();
            Country output = acd.Display();

            CountryDb.Add(output);
        }
    }
}
