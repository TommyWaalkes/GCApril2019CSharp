using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class Elephant : IAnimal
    {
        public string GetFood()
        {
            return "Peanuts";
        }

        public string MakeSound()
        {
            return "Bruuuuuuuu";
        }
    }
}
