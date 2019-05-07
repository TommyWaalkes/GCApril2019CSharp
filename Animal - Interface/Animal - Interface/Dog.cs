using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class Dog : IAnimal
    {
        public string GetFood()
        {
            return "treats";
        }

        public string MakeSound()
        {
            return "Woof!";
        }

        public string Whine()
        {
            return "Whimper Whine!";
        }
    }
}
