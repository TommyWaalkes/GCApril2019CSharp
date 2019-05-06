using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            
        }

        public override string GetFood()
        {
            return "Dog treats and kibble";
        }

        public override void PrintFood()
        {
            Console.WriteLine($"The Dog {name} eats {GetFood()}");
        }
    }
}
