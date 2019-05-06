using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird tweet = new Bird("Mark Fidrych");
            tweet.PrintFood();
            if (tweet.HasFeathers())
            {
                Console.WriteLine("Our Bird has nice Feathers");
            }

            //So right here were creating an animal why do we need a string here?
            Animal a = new Animal("Jeff");

            a.PrintFood();
            Console.WriteLine(a.GetColor());
            Console.WriteLine();

            //Why does dog take a string in its constructor?
            Dog d = new Dog("Borkins");
            d.PrintFood();
            Console.WriteLine(d.GetColor());

            Console.WriteLine();
            //Cat's constructor has an extra parameter, why is that?
            Cat c = new Cat(false, "McFluffy");
            c.PrintFood();
            Console.WriteLine(c.GetColor());

            //Woah! I thought C# was strongly typed, why am I able to put cats and dogs
            //When my list clear is of type animal? This list is breaking all the rules!
            List<Animal> animals = new List<Animal>();

            animals.Add(a);
            animals.Add(d);
            animals.Add(c);

            foreach(Animal ans in animals)
            {
                ans.PrintFood();
            }
        
        }
    }
}
