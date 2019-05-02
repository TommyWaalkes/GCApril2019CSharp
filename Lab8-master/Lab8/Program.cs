using System;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        public static string[] names = new string[100];
        public static string[] foods = new string[100];
        public static string[] towns = new string[100];
        public static List<Student> Students = new List<Student>();

        static void Main(string[] args)
        {

            AddStudent("Tommy", "Raleigh", "chicken curry");
            Student studentInfo = GetStudent(0);
            AddStudent("Callista", "Traverse City", "crab rangoon");
            Student studentInfo1 = GetStudent(1);
            AddStudent("Andre", "St. Catherine's", "veggie burgers");
            Student studentInfo2 = GetStudent(2);
            AddStudent("Brad", "Kentwood", "sushi");
            GetInput();
        }

        public static void AddStudent(string name, string town, string food)
        {
            Student s = new Student(name, town, food);
            Students.Add(s);
            //names[index] = name;
            //foods[index] = food;
            //towns[index] = town;
        }

        public static Student GetStudent(int index)
        {
            //string output = $"{names[index]} {foods[index]} {towns[index]}";
            Student output = Students[index];
            return output;
        }

        public static void PrintMenu()
        {
            for (int i = 0; i < Students.Count; i++)
            {
                Student s = Students[i];
                string name = s.Name;
                if (name != null)
                {
                    Console.WriteLine(i + ") " + name);
                }
            }
        }

        public static void GetInput()
        {
            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about?");
            PrintMenu();
            Console.WriteLine("Select 0 to 3.");
            int index = 0;
            //int studentNumber;
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    index = int.Parse(input);
                    if (index >= 0)
                        break;
                    throw new Exception("That student doesn't exist. Please enter a number from 0 to 3.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Student s = GetStudent(index);
            Console.WriteLine($"Student at {index} is {s.Name}");
            if (0 <= index && index < Students.Count)
            {

                Console.WriteLine("What would you like to know about {0}? Please enter 'hometown' or 'favorite food.' ", names[index]);
                string userInput = (Console.ReadLine());

                if (userInput == "hometown")
                {
                   
                    Console.WriteLine($"{s.Name} is from {s.HomeTown}");
                   //Console.WriteLine("Would you like to know more? (y/n)");
                    Continue();
                }
                else if (userInput == "favorite food")
                {
                    Console.WriteLine($"{s.Name}'s favorite food is {s.FavoriteFood}");
                    //Console.WriteLine("Would you like to know more?(y/n)");
                    Continue();
                }
                else
                {
                    Console.WriteLine("That data does not exist.");
                    Continue();
                }
            }


        }
        public static void Continue()
        {
            bool play = true;

            while (play)
            {
                Console.WriteLine("Would you like to know more? (y/n)");
                string input = Console.ReadLine().ToLower();

                if (input == "y" || input == "yes")
                {
                    GetInput();
                }

                else if (input == "n" || input == "no")
                {
                    Console.WriteLine("Thanks!");
                    play = false;
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("I'm sorry that I didn't understand your input. Goodbye.");
                    System.Environment.Exit(0);
                }

            }


        }
    }
}