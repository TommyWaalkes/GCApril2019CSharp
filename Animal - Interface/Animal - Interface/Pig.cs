using AnimalInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jimmy
{
    class Pig : IAnimal
    {
        public string GetFood()
        {
            return "Anything";
        }

        public string MakeSound()
        {
            return "oink";
        }
    }
}
