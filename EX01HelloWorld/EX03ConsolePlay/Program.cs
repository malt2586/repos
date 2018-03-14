using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03ConsolePlay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 3.1
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            Console.ReadKey();

            //Opgave 3.2
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Sort på hvid.");

            Console.ReadKey();

            //Opgave 3.3
            Console.WindowHeight = 10;
            Console.WindowWidth = 10;

            Console.ReadKey();

            //Opgave 3.4
            Console.Beep(4000, 1000);

            Console.ReadKey();
        }
    }
}
