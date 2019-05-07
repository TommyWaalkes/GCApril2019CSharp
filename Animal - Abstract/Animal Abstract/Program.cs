using System;

namespace AnimalAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Narwhal Facts");
            Narwhal n = new Narwhal("Nelly");
            Console.WriteLine( n.MakeSound());
            n.PrintFood();
            Console.WriteLine();
            Seal s = new Seal(); 
            Console.WriteLine("Seal Info");
            Console.WriteLine("The seal eats " +s.GetFood() );
            Console.WriteLine("The seal goes " + s.MakeSound());
            Console.WriteLine("The seal is alive: " + s.IsAlive());
            Console.WriteLine();

            Animal a = new Llama();

            Console.WriteLine(a.GetColor());
            Console.WriteLine(a.HasFeathers());

            Llama la = new Llama();

            Console.WriteLine(la.GetColor());
            Console.WriteLine(la.HasFeathers());

            Dog d = new Dog();
            Cat c = new Cat();
            Chimp m = new Chimp();
            Llama l = new Llama();
            Goat g = new Goat();
            VelociaRaptor r = new VelociaRaptor();
            Husky h = new Husky();

            Console.WriteLine(d.MakeSound());
            Console.WriteLine("The dog eats "+d.GetFood());
            Console.WriteLine(c.MakeSound());
            Console.WriteLine("The cat eats "+c.GetFood());
            Console.WriteLine(m.MakeSound());
            Console.WriteLine("The chimp eats " + m.GetFood());

            Console.WriteLine(l.MakeSound());
            Console.WriteLine("The llama eats " + l.GetFood());

            Console.WriteLine(g.MakeSound());
            g.PrintFood();

            Console.WriteLine(r.GetFood());
            Console.WriteLine(r.MakeSound());
            r.PrintFood();
            Console.WriteLine(h.GetFood());
            Console.WriteLine(h.MakeSound());
        }
    }
}