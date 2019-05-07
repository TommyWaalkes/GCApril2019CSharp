using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    class Narwhal : Animal
    {
        
        public Narwhal(string name)
        {
            this.name = name;
        }

        public override string GetFood()
        {
           
            return "Sharks and people, shrimp, cod, squid, anything really";
        }


    }
}
