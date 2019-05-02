using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class CircleApp
    {
        private List<Circle> circles = new List<Circle>();

        public void PrintCircles()
        {
            //circles.Add(new Circle(19));
            //circles.Add(new Circle(60));
            //circles.Add(new Circle(1.5));
            for (int i = 0; i < circles.Count; i++)
            {
                Circle c = circles[i];
                Console.WriteLine("Circle " + (i +1));
                c.PrintInfo();
                Console.WriteLine();
            }
        }

        public void Run()
        {
            //0 Start a loop
            //1 Ask for a radius 
            //2 Validate user input and parse it 
            //3 Create Circle object 
            //4 Store circle in list 
            //5 Ask user if they want to start again 
            bool run = true;
            while(run == true)
            {
                Console.WriteLine("Please input a double radius");
                string input = Console.ReadLine();
                double radius = 0;
                try
                {
                    radius = double.Parse(input);
                }
                catch(FormatException e)
                {
                    Console.WriteLine("The input was not a valid double try again please");
                    continue;
                }

                Circle c = new Circle(radius);
                circles.Add(c);
                Console.WriteLine("Your fresh made circle:");
                c.PrintInfo();
                Console.WriteLine("Would you like to make another circle? Y/N");

                string answer = Console.ReadLine();
                if(answer.ToLower() == "y")
                {
                    run = true;
                }
                else if(answer == "n")
                {
                    run = false;
                }
                else
                {
                    Console.WriteLine("Hey I didn't follow, I'm going to assume you want to continue");
                }
            }
            Console.WriteLine($"You made {circles.Count} circles");
            PrintCircles();
        }
    }
}
