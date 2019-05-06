using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLab11
{
    public class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, string Category, int RunTime, List<string > Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Movie info: ");
            Console.WriteLine(Title);
            Console.WriteLine(Category);
            Console.WriteLine(RunTime);
            PrintScenes();
        }

        public void PrintScenes()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i}: {Scenes[i]}");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine("The play method only works on physical media");
        }
    }
}
