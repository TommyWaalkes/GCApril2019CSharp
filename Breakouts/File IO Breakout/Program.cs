using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //We need to create a reader and read to end to the get data out 
            //That data comes back as a big string, so we'll need our string methods 
            
           
            List<string> countries;
            //You will have to change this for yourself
            string filePath = @"C:\Users\Tommy\Desktop\File IO Breakout\Countries.txt";
            //Lastly to save, we need save, the way you do that is via a streamWriter 
            StreamReader reader;
            StreamWriter writer;
            try
            {
                reader = new StreamReader(filePath);
                string fileOutput = reader.ReadToEnd();
                List<string> existingCountries = fileOutput.Split(',').ToList();
                
                Console.WriteLine("Existing Countries in the file: ");
                PrintCountryList(existingCountries);

                Console.WriteLine("Please input a country name");
                string inputCountry = Console.ReadLine();
                Console.WriteLine("Adding new country...");
                Console.WriteLine();

                if (!fileOutput.Contains(inputCountry))
                {
                    fileOutput += $", {inputCountry}";
                    Console.WriteLine("New Country added!");
                    Console.WriteLine(fileOutput);
                }
                else
                {
                    Console.WriteLine("That country already exists, the file has not been changed");
                    Console.WriteLine(fileOutput);
                }

                countries = fileOutput.Split(',').ToList();
                reader.Close();

                writer = new StreamWriter(filePath);
                writer.Write(fileOutput);

                writer.Close();
                PrintCountryList(countries);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            //Where have we seen read and write before?

           
        }

        public static void PrintCountryList(List<string> countries)
        {
            foreach(string country in countries)
            {                
                Console.WriteLine(country.Trim());
            }
        }
    }
}
