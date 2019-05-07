using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class Chimp : IAnimal
    {
        public string GetFood()
        {
            return "Bananas";
        }

        public string MakeSound()
        {
            return "Ek Screech";
        }
    }
}
