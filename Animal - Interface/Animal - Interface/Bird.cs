using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class Bird : IAnimal
    {
        public string GetFood()
        {
            return "Seeds and nuts";
        }

        public string MakeSound()
        {
            return "Caw Caw!";
        }
    }
}
