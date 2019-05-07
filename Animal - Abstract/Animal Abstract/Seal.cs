using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    class Seal : Animal
    {
        public override string GetFood()
        {
            return "Fish";
        }

        public override string MakeSound()
        {
            return "Arf arf arf";
        }
    }
}
