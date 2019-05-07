using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    abstract class Animal
    {
        protected string name;
        public virtual string MakeSound()
        {
            return "Not much is known about this animal!";
        }
        public abstract string GetFood();

        public void PrintFood()
        {
            Console.WriteLine(name + " animal eats " +GetFood());
        }
        
        public virtual bool HasFeathers()
        {
            return false;
        }

        public string GetColor()
        {
            return "red";
        }

        public bool IsAlive()
        {
            return true;
        }
    }       
}           
            