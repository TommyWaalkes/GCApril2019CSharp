using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rocky r = new Rocky("Balboa");

            //Console.WriteLine($"{r.Name} throws {r.GenerateRoShamBo()}");

            //Random rando = new Random();
            //Randy marsh = new Randy("Randy Marsh", rando);

            //for(int i = 0; i<10; i++)
            //{
            //    Console.WriteLine($"{marsh.Name} throws {marsh.GenerateRoShamBo()}");
            //}

            RPSApp ra = new RPSApp();
            ra.Run();
        }
    }
}
