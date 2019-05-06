using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    class Cat : Animal
    {
        bool cleanLitterBox;
        public Cat(bool cleanLitterBox, string name) : base(name)
        {
            this.cleanLitterBox = cleanLitterBox;
        }

        public override string GetFood()
        {
            return "Mice, Kibble, and lint";
        }

        public override void PrintFood()
        {
            Console.WriteLine($"{name} the cat eats {GetFood()}, but also likes hunting");
        }
    }
}
