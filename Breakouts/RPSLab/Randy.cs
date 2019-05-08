using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLab
{
    class Randy : Player
    {
        public Random R { get; set; }

        public Randy(string Name, Random R) : base(Name)
        {
            this.R = R;
        }

        public override string GenerateRoShamBo()
        {
            int choice = R.Next(0, 3);
            List<string> rpsValues = new List<string>() { RPS.Rock, RPS.Paper, RPS.Scissors };
            return rpsValues[choice];
        }
    }
}
