using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewController
{
    class CarModel
    {
        List<string> carNames = new List<string>();
        public CarModel()
        {
            carNames.Add("Pope Mobile");
            carNames.Add("Camry");
            carNames.Add("Bat Mobile");
            carNames.Add("Invisible Jet");
            carNames.Add("Wienermobile");
        }

        public List<string> GetNames()
        {
            return carNames;
        }
    }
}
