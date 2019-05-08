using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewController
{
    class Model
    {
        List<string> names = new List<string>();
        public Model()
        {
            names.Add("Tommy");
            names.Add("joey");
            names.Add("Phil");
            names.Add("Billy");
            names.Add("Notorious T Wizzle");
        }
        public string GetName(int index)
        {
            return names[index];
        }

        public List<string> GetAllNames()
        {
            return names;
        }
    }
}
