using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    class VelociaRaptor : Animal
    {
       // private string name = "Raptor of the velocity";
        
        public VelociaRaptor()
        {
            base.name = "Raptor";
        }

        public override string GetFood()
        {
            return "Just about any meat";
        }

        public override string MakeSound()
        {
            return "click click click";
        }
    }
}
