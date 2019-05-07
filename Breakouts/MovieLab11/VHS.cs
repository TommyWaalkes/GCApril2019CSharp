using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLab11
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }
        //Constructor
        public VHS(string Title, string Category, int RunTime, List<string> Scenes)
            : base(Title, Category, RunTime, Scenes)
        {
            CurrentTime = 2;
        }

        public override void Play()
        {
            if (CurrentTime < Scenes.Count)
            {
                string s = Scenes[CurrentTime];
                Console.WriteLine(s);
                CurrentTime++;
            }
            else
            {
                Rewind();
            }
        }

        public void Rewind()
        {
            Console.WriteLine("Movie done! Rewinding...");
            Console.WriteLine();
            CurrentTime = 0;
        }

    }
}
