using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewController
{
    class Controller
    {
        Model m;
        CarModel cm; 
        View v;
        WelcomeView wv;
        public Controller()
        {
            m = new Model();
            cm = new CarModel();
            v = new View();
            wv = new WelcomeView();
        }

        public void DisplayWelcome()
        {
            wv.Welcome();
        }

        public void DisplayNames()
        {
            v.DisplayNames(m.GetNames());

        }
    }
}
