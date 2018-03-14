using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX15Methods
{
    class Program
    {
        //Opgave 15.1-15.2
        //Method printing message to console
        private static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        //Method printing message to console
        private static void SayGoodbye(string name)
        {
            Console.WriteLine($"Goodbye {name}.");
        }

        //Opgave 15.3
        //Method returning double int "number"
        private static int DoubleUp(int number)
        {
            return number * 2;
        }

        //Opgave 15.4
        //Method returning sum of int "number1, number2"
        private static int SumOf(int number1, int number2)
        {
            return number1 + number2;
        }

        //Opgave 15.5
        //Method returning highest of int "number1, number2"
        private static int HighestOf(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        //Opgave 15.6
        //Method printing values in string[] "array"
        private static void PrintArray(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
