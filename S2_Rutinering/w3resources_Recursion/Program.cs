using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3resources_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Excersise 1
            //int n = 1;
            //NaturalNumbers(n);
            //Console.ReadKey();

            ////Excersise 2
            //int n = 5;
            //Console.WriteLine($"Sum of numbers from 1 to {n}: {SumOfNumbers(n)}");
            //Console.ReadKey();

            ////Excersise 3
            //int terms = 10;
            //Console.WriteLine("The Series are :");
            //PrintFibonacci(0, 1, 1, terms);
            //Console.ReadKey();

            ////Excersise 4
            //int[] arr = new int[6] { 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine($"The elements in the array are: {PrintArray("", 0, arr)}");
            //Console.ReadKey();

            ////Excersise 5
            //int input = 50;
            //Console.WriteLine(CountDigits(input));
            //Console.ReadKey();

            //Excersise 6
            int input = 25;
            Console.WriteLine(SumOfDigits(input));
            Console.ReadKey();
        }

        //Excersise 1
        public static int NaturalNumbers(int n)
        {
            if (n <= 50)
            {
                Console.WriteLine($" {n}");
                return NaturalNumbers(n + 1);
            }
            return n;
        }

        //Excersise 2
        public static int SumOfNumbers(int n)
        {
            int sum;
            if (n == 1)
            {
                return 1;
            }
            else
            {
                sum = n + SumOfNumbers(n - 1);
            }
            return sum;
        }

        //Excersise 3
        public static void PrintFibonacci(int a, int b, int counter, int terms)
        {
            Console.Write($"{b} ");
            if (counter < terms)
            {
                PrintFibonacci(b, a + b, ++counter, terms);
            }
        }

        //Excersise 4
        public static string PrintArray(string s, int count, int[] array)
        {
            string result = s;
            if (count < array.Length)
            {
                result = s + array[count] + " ";
                return PrintArray(result, ++count, array);
            }
            return result;
        }

        //Excersise 5
        public static int CountDigits(int input)
        {
            int count = 0;
            if (input != 0)
            {
                count = CountDigits(input / 10) + 1;
            }
            return count;
        }

        //Excersise 6
        public static int SumOfDigits(int input)
        {
            int sum = 0;
            if (input != 0)
            {
                sum = 
            }
            return sum;
        }
    }
}
