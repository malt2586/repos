using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13Arrays
{
    class Program
    {
        //Object generating random number
        static Random random = new Random();

        static void Main(string[] args)
        {
            //Opgave 13.1
            //Create new array
            int[] arr = new int[5];

            //Populate array
            arr[0] = 25;
            arr[1] = 28;
            arr[2] = 15;
            arr[3] = 35;
            arr[4] = 14;

            //For loop printing array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("\n");

            //Opgave 13.2
            //Create new array and populate
            string[] names = new string[5] { "Mikkel", "Hans", "Julie", "Tina", "Martin" };

            //For loop printing array
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]}, ");
            }
            Console.WriteLine("\n");

            //Replace names[1]
            names[1] = "Kong Hans";

            //For loop printing array
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]}, ");
            }
            Console.WriteLine("\n");

            //Opgave 13.3
            //Create new array and populate
            int[] numbers = new int[10] { 7, 79, 95, 73, 78, 18, 76, 80, 60, 21 };

            //For loop printing array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine("\n");

            //Sort array numbers low-high
            Array.Sort(numbers);

            //For loop printing array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine("\n");

            //Sort array numbers high-low
            Array.Reverse(numbers);

            //For loop printing array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine("\n");

            //Opgave 13.4
            //For loop adding 5 to each value in array numbers and prints
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] + 5;
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine("\n");

            //For loop replacing each value in array numbers with a random number(1-100) and prints
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine("\n");

            //Wait for key press to exit
            Console.ReadKey();
        }
    }
}
