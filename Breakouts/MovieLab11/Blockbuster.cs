using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLab11
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; }

        public Blockbuster()
        {
            Movies = new List<Movie>();
            List<string> DumbScenes = new List<string>() { "swindle blind kid", "kill gas man", "buy leisure suits" };
            VHS dumbDumber = new VHS("Dumb and Dumber", "Comedy", 120, DumbScenes);
            Movies.Add(dumbDumber);

            List<string> HangOverScenes = new List<string>() { "Tiger Mike Tyson Scene", "Drink a lot", "Find Doug on Roof" };
            VHS HangOver = new VHS("The Hang Over", "Comedy", 60, HangOverScenes);
            Movies.Add(HangOver);

            List<string> FindingNemoScenes = new List<string>() { "Nemo gets stolen", "Jellyfish", "Dentist Scenes" };
            DVD FindingNemo = new DVD("Finding Nemo", "Disney", 90, FindingNemoScenes);
            Movies.Add(FindingNemo);

            List<string> FrozenScenes = new List<string>() { "Ice stuff", "Wana build a snow man", "Snow Scene" };
            DVD Frozen = new DVD("Frozen", "Disney", 90, FrozenScenes);
            Movies.Add(Frozen);

        }

        public void PrintMovies()
        {
            for(int i =0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                Console.WriteLine($"{i}: {m.Title}");
            }
        }

        public void CheckOut()
        {
            Console.WriteLine("Please select an index from the following list: ");
            PrintMovies();
            string input = Console.ReadLine();
            int index = int.Parse(input);

            Movie m = Movies[index];
            m.PrintInfo();
            m.Play();

        }

    }
}
