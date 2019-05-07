using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    class Cat : Animal
    {
        public override string GetFood()
        {
            return "mice";
        }

        public override string MakeSound()
        {
            return "meow";
        }

    }
}
