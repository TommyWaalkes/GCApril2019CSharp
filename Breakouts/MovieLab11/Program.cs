using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Scenes = new List<string>(){"Capture Leia", "Blow up deathstar", "Pizza the Hut"};
            Movie m = new Movie("Space Balls","Comedy", 120, Scenes);

            m.PrintInfo();
            m.Play();
            Console.WriteLine();

            List<String> Scenes2 = new List<string>() { "Cantina Scene", "Jefferson Starship", "Bobba Fett Cartoon" };
            DVD d = new DVD("Star Wars Holiday Special", "Hot Mess", 80, Scenes2);
            d.Play();
        }
    }
}
