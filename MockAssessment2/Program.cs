using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment2
{
    class Program
    {
        public static List<string> tasks = new List<string>();
        static void Main(string[] args)
        {
        }

        public static void AddTask(string s)
        {
            tasks.Add(s);
        }
    }
}
