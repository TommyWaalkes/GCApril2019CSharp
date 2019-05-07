using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class Kola : IAnimal
    {

        public string GetFood()
        {
            return "Leaves and each other";
        }

        public string MakeSound()
        {
            return "Screams of the dammned";
        }
    }
}
