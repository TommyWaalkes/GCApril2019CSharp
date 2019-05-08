using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewController
{
    class View
    {
        public void PrintName(string s)
        {
            Console.WriteLine("Hello "+s);
        }

        public void DisplayNames(List<string> names)
        {
            foreach(string name in names)
            {
                Console.WriteLine("Hello "+name);
            }
        }
    }
}
