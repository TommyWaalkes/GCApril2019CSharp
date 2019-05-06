using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    public class Animal
    {
        protected string name;
        protected bool hasFeathers = false;
        public Animal(string name)
        {
            this.name = name;
        }

        public string MakeSound()
        {
            return "Not much is known about this animal!";
        }

        //Virtual methods children have the option to take it as is OR to override it
        public virtual string GetFood()
        {
            return "Grass or meat or something";
        }

        public virtual void PrintFood()
        {
            Console.WriteLine(name + " the animal eats " + GetFood());
        }

        public bool HasFeathers()
        {
            return hasFeathers;
        }

        public string GetColor()
        {
            return "brown";
        }
    }
}
