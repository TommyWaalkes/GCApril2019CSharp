using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    class Bird : Animal
    {
        public Bird(string Name) : base(Name)
        {
            hasFeathers = true;
        }

        public override string GetFood()
        {
            return "Seed";
        }

        public override void PrintFood()
        {
            Console.WriteLine($"{name} the bird eats {GetFood()}");
        }
    }
}
