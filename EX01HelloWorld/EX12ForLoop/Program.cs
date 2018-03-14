using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12ForLoop
{
    class Program
    {
        //Object generating random number
        static Random random = new Random();

        static void Main(string[] args)
        {
            //Opgave 12.1

            //For loop (print 1-10)
            for (int count = 0; count < 10; count++)
            {
                Console.Write($"{count + 1} ");
            }
            Console.WriteLine("\n");

            //For loop (print 10-1)
            for (int count = 0; count < 10; count++)
            {
                Console.Write($"{10 - count} ");
            }
            Console.WriteLine("\n");

            //For loop (print even 1-20)
            for (int count = 0; count < 20; count++)
            {
                if ((count + 1) % 2 == 0)
                {
                    Console.Write($"{count + 1} ");
                }
            }
            Console.WriteLine("\n");

            //For loop (print eneven 1-20)
            for (int count = 0; count < 20; count++)
            {
                if ((count + 1) % 2 == 0)
                {
                    Console.Write($"{count} ");
                }
            }
            Console.WriteLine("\n");

            //Opgave 12.2
            //For loop (print 7-table)
            for (int count = 0; count < 10; count++)
            {
                Console.Write($"{(count + 1) * 7} ");
            }
            Console.WriteLine("\n");

            //For loop (print 13-table)
            for (int count = 0; count < 10; count++)
            {
                Console.Write($"{(count + 1) * 13} ");
            }
            Console.WriteLine("\n");

            //Opgave 12.3
            //For loop (print table)
            for (int table = 0; table < 10; table++)
            {
                for (int count = 0; count < 10; count++)
                {
                    Console.Write($"{(count + 1) * (table + 1)}".PadLeft(4));
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            //Opgave 12.4
            //For loop (print 10 random numbers 1-6)
            for (int rollCount = 0; rollCount < 10; rollCount++)
            {
                int roll = random.Next(1, 7);
                Console.Write($"{roll} ");
            }
            Console.WriteLine("\n");

            //Roll
            int rollWhile = 0;

            //While loop (print random number 1-6 untill 6)
            while (rollWhile != 6)
            {
                rollWhile = random.Next(1, 7);
                Console.Write($"{rollWhile} ");
            }
            Console.WriteLine("\n");

            //Wait for key press to exit
            Console.ReadKey();
        }
    }
}
