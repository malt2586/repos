using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EX20StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPGAVE 20.1
            using (StreamWriter writer = new StreamWriter("MyFile.txt"))
            //using (StreamWriter writer = new StreamWriter(@"C:\Users\malt2586\Desktop\MyFile.txt"))
            {
                //Writes text on a line
                writer.Write("Dette bliver skrevet på en linje");
                writer.Write(".. og det her fortsætter på samme linje");

                //Writes text on a line, followed by a linebreak
                writer.WriteLine(".. det her står på samme linje, men afsluttes med nyt linjeskift");
                writer.WriteLine("Forskellen på Write og WriteLine er altså om den bliver afsluttet med nyt linjeskift eller ej");
                writer.WriteLine("1");
                writer.WriteLine("2");
            }

            //OPGAVE 20.2
            using (StreamWriter writer = new StreamWriter("RandomNumbers.txt"))
            {
                //Creates new Random object to generate random numbers
                Random rnd = new Random();

                for (int i = 0; i < 100; i++)
                {
                    //Generates a random number between [1-7[ and writes it on a line, followed by a linebreak
                    writer.WriteLine(rnd.Next(1, 7));
                }
                
            }

            SaveRandomNumbers(50, @"RandomNumbersMethod.txt");

            //OPGAVE 20.3
            //Creates new empty list
            List<int> numbers = new List<int>();

            using (StreamReader reader = new StreamReader(@"RandomNumbers.txt"))
            {
                //Runs untill the stream ends
                while (!reader.EndOfStream)
                {
                    //Parses each line and adds the value(int) to the list
                    numbers.Add(int.Parse(reader.ReadLine()));
                }
            }

            //Sorts the list ascending (low-high)
            numbers.Sort();

            using (StreamWriter writer = new StreamWriter(@"SortedNumbers.txt"))
            {
                //Runs through the list
                foreach (int number in numbers)
                {
                    //Writes values from the list to file
                    writer.WriteLine(number);
                }
            }

            Console.WriteLine("Der er:");

            //Creates new empty list
            List<int> result;

            //Runs for each possible value (1-6)
            for (int i = 0; i < 6; i++)
            {
                //Finds all values (n) and writes them to the list "result"
                result = numbers.FindAll(delegate (int n)
                {
                    return n == i + 1;
                }
                );

                //Prints the count and the value to console
                Console.WriteLine($"{result.Count()} {i + 1}-taller");
            }
            Console.WriteLine("\nPress any key to continue ...");

            //Wait for key press to exit
            Console.ReadKey();
        }

        //OPGAVE 20.2
        //Method taking 2 values, int(number of random numbers to write), string(path to save the file) and writes to a text file
        private static void SaveRandomNumbers(int numbers, string url)
        {
            using (StreamWriter writer = new StreamWriter(url))
            {
                //Creates new Random object to generate random numbers
                Random rnd = new Random();

                for (int i = 0; i < numbers; i++)
                {
                    //Generates a random number between [1-7[ and writes it on a line, followed by a linebreak
                    writer.WriteLine(rnd.Next(1, 7));
                }

            }
        }
    }
}
