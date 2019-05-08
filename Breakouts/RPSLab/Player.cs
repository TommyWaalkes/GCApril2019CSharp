using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLab
{
    abstract class Player
    {
        public string Name { get; set; }
        public string RPSValue { get; set; }

        public Player(string Name)
        {
            this.Name = Name;
        }

        public abstract string GenerateRoShamBo();
    }
}
