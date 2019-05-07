using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    class Goat : Animal
    {
        public Goat()
        {
            name = "goat";
        }
        public override string GetFood()
        {
            return "hay";
        }

        public override string MakeSound()
        {
            return "Baaaa";
        }
    }
}
