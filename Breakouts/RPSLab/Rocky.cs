using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLab
{
    class Rocky : Player
    {
        public Rocky(string Name) : base(Name)
        {

        }
        public override string GenerateRoShamBo()
        {
            return RPS.Rock;
        }
    }
}
