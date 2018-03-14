using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraEX01MathQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;

            Console.WriteLine("Hvad er 5+5?");
            if (double.Parse(Console.ReadLine()) == (5 + 5))
            {
                ++points;
            }
            Console.Clear();
            Console.WriteLine("Hvad er 13-5?");
            if (double.Parse(Console.ReadLine()) == (13 - 5))
            {
                ++points;
            }
            Console.Clear();
            Console.WriteLine("Hvad er 4 - 9??");
            if (double.Parse(Console.ReadLine()) == (4 - 9))
            {
                ++points;
            }
            Console.Clear();
            Console.WriteLine("Hvad er 3*2?");
            if (double.Parse(Console.ReadLine()) == (3 * 2))
            {
                ++points;
            }
            Console.Clear();
            Console.WriteLine("Hvad er 3+10-3?");
            if (double.Parse(Console.ReadLine()) == (3 + 10 - 3))
            {
                ++points;
            }
            Console.Clear();
            Console.WriteLine($"Points: {points}");

            Console.ReadKey();
        }
    }
}
