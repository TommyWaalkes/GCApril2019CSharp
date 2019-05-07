using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class Fox : IAnimal
    {
        public string GetFood()
        {
            return "pests, vermin";
        }

        public string MakeSound()
        {
            return "Yip yip yip yip yip yip yip yip yip";
        }
    }
}
