using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11While
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Opgave 11.1
            ////Counter
            //int intCount = 1;

            //Console.WriteLine();
            ////Loop intCount (print 1-10)
            //while (intCount <= 10)
            //{
            //    //Print intCount
            //    Console.WriteLine(intCount);

            //    //Increment intCount
            //    intCount++;
            //}
            ////Reset intCount to 1
            //intCount = 1;

            //Console.WriteLine();
            ////Loop intCount (print 10-1)
            //while (intCount <= 10)
            //{
            //    //Print intCount
            //    Console.WriteLine(11 - intCount);

            //    //Increment intCount
            //    intCount++;
            //}
            ////Reset intCount to 1
            //intCount = 1;

            //Console.WriteLine();
            ////Loop intCount (print even 1-20)
            //while (intCount <= 20)
            //{
            //    //intCount modulo 2 to evaluate if even
            //    if (intCount % 2 == 0)
            //    {
            //        //Print intCount
            //        Console.WriteLine(intCount);
            //    }

            //    //Increment intCount
            //    intCount++;
            //}
            ////Reset intCount to 1
            //intCount = 1;

            //Console.WriteLine();
            ////Loop intCount (print uneven 1-20)
            //while (intCount <= 20)
            //{
            //    //intCount modulo 2 to evaluate if uneven
            //    if (intCount % 2 > 0)
            //    {
            //        //Print intCount
            //        Console.WriteLine(intCount);
            //    }

            //    //Increment intCount
            //    intCount++;
            //}
            ////Reset intCount to 1
            //intCount = 1;

            ////Opgave 11.2
            ////Counter
            //int intCount;

            //Console.WriteLine();
            ////Set intCount to start number
            //intCount = 7;

            ////Loop intCount (print 7-table)
            //while (intCount <= 70)
            //{
            //    //Print intCount
            //    Console.WriteLine(intCount);

            //    //Increment intCount
            //    intCount = intCount + 7;
            //}

            //Console.WriteLine();
            ////Set intCount to start number
            //intCount = 13;

            ////Loop intCount (print 13-table)
            //while (intCount <= 130)
            //{
            //    //Print intCount
            //    Console.WriteLine(intCount);

            //    //Increment intCount
            //    intCount = intCount + 13;
            //}

            //Console.WriteLine();

            //Console.Write("Input any even number: ");
            ////Parse input and set table
            //int table = int.Parse(Console.ReadLine());

            ////Set intCount to table
            //intCount = table;

            ////Loop intCount (print table)
            //while (intCount <= table * 10)
            //{
            //    //Print intCount
            //    Console.WriteLine(intCount);

            //    //Increment intCount
            //    intCount = intCount + table;
            //}

            ////Opgave 11.3

            ////Counter
            //int table = 1;

            ////Loop table
            //while (table <= 10)
            //{
            //    int intCount = table;

            //    //Loop intCount (print table)
            //    while (intCount <= table * 10)
            //    {
            //        //Print intCount
            //        Console.Write(intCount.ToString().PadLeft(4));

            //        //Increment intCount
            //        intCount = intCount + table;
            //    }
            //    Console.WriteLine();

            //    //Increment table
            //    table++;
            //}

            //Opgave 11.4
            //User input
            int input = 0;

            while (input > 10 || input < 1)
            {
                Console.Write("Input number 1-10: ");
                input = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            //Wait for key press to exit
            Console.ReadKey();
        }
    }
}
