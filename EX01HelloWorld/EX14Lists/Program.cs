using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 14.1
            //Creates new list "ages"
            List<int> ages = new List<int>();

            //Adds values to list "ages"
            ages.Add(5);
            ages.Add(17);
            ages.Add(20);
            ages.Add(40);
            ages.Add(51);

            //Creates new list "names"
            List<string> names = new List<string>();

            //Adds values to list "names"
            names.Add("Jens");
            names.Add("Karl");
            names.Add("Johannes");
            names.Add("Anton");
            names.Add("Nicklas");

            //Opgave 14.2
            //Creates new list "percentages" and adds values
            List<double> percentages = new List<double>() { 0.75, 0.23, 0.86, 0.17 };

            //Creates new list "areMarried" and adds values
            List<bool> areMarried = new List<bool>() { true, false, false, true, true };

            //Opgave 14.3
            //For loop printing values in list "ages"
            for (int age = 0; age < ages.Count; age++)
            {
                Console.Write($"{ages[age]} ");
            }
            Console.WriteLine("\n");

            //For loop printing values in list "names"
            for (int name = 0; name < names.Count; name++)
            {
                Console.Write($"{names[name]}, ");
            }
            Console.WriteLine("\n");

            //Foreach loop printing values in list "percentages"
            foreach (var percentage in percentages)
            {
                Console.Write($"{percentage} ");
            }
            Console.WriteLine("\n");

            //Foreach loop printing values in list "areMarried"
            foreach (var value in areMarried)
            {
                Console.Write($"{value}, ");
            }
            Console.WriteLine("\n");

            //Opgave 14.4
            //Foreach loop printing values in list "names"
            foreach (var name in names)
            {
                Console.Write($"{name}, ");
            }
            Console.WriteLine("\n");

            //Method inserting values in list "names"
            names.Insert(3, "Anders");
            names.Insert(2, "Lars");

            //Foreach loop printing values in list "names"
            foreach (var name in names)
            {
                Console.Write($"{name}, ");
            }
            Console.WriteLine("\n");

            //Opgave 14.5
            //Creates new list "numbers" and adds values
            List<int> numbers = new List<int>() { 13, 14, 13, 15, 13, 14, 14, 15 };

            //Foreach loop printing values in list "numbers"
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\n");

            //Removes first occurence of values "13, 15" from list "numbers"
            numbers.Remove(13);
            numbers.Remove(15);

            //Foreach loop printing values in list "numbers"
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\n");

            //Removes value at index 3 from list "numbers"
            numbers.RemoveAt(3);

            //Foreach loop printing values in list "numbers"
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\n");

            //Wait for key press to exit
            Console.ReadKey();
        }
    }
}
