using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Opgave 6.1
            //float input;
            //float discount;

            //Console.Write("Input: ");
            //input = float.Parse(Console.ReadLine());
            //if (input > 1000)
            //{
            //    discount = 5;
            //}
            //else
            //{
            //    discount = 0;
            //}
            //Console.WriteLine($"Discount: {discount} %");

            //Console.ReadKey();

            ////Opgave 6.2-6.3
            //int input1;
            //int input2;
            //int input3;

            //Console.Write("Input 1: ");
            //input1 = int.Parse(Console.ReadLine());
            //Console.Write("Input 2: ");
            //input2 = int.Parse(Console.ReadLine());
            //Console.Write("Input 3: ");
            //input3 = int.Parse(Console.ReadLine());

            //if (input1 < input2)
            //{
            //    if (input2 < input3)
            //    {
            //        Console.WriteLine(input1);
            //        Console.WriteLine(input2);
            //        Console.WriteLine(input3);
            //    }
            //    else if (input3 < input1)
            //    {
            //        Console.WriteLine(input3);
            //        Console.WriteLine(input1);
            //        Console.WriteLine(input2);
            //    }
            //    else
            //    {
            //        Console.WriteLine(input1);
            //        Console.WriteLine(input3);
            //        Console.WriteLine(input2);
            //    }
            //}
            //else
            //{
            //    if (input1 < input3)
            //    {
            //        Console.WriteLine(input2);
            //        Console.WriteLine(input1);
            //        Console.WriteLine(input3);
            //    }
            //    else if (input3 < input2)
            //    {
            //        Console.WriteLine(input3);
            //        Console.WriteLine(input2);
            //        Console.WriteLine(input1);
            //    }
            //    else
            //    {
            //        Console.WriteLine(input2);
            //        Console.WriteLine(input3);
            //        Console.WriteLine(input1);
            //    }
            //}

            //Console.ReadKey();

            ////Opgave 6.4
            //int input1;
            //int input2;

            //Console.Write("Input 1: ");
            //input1 = int.Parse(Console.ReadLine());
            //Console.Write("Input 2: ");
            //input2 = int.Parse(Console.ReadLine());

            //if (input1 == input2)
            //{
            //    Console.WriteLine("De to tal er ens");
            //}
            //else
            //{
            //    Console.WriteLine("De to tal er ikke ens");
            //}
            //Console.ReadKey();

            ////Opgave 6.5
            //float a;
            //float b;

            //Console.Write("Input a: ");
            //a = float.Parse(Console.ReadLine());
            //Console.Write("Input b: ");
            //b = float.Parse(Console.ReadLine());

            //if (b != 0)
            //{
            //    Console.Write($"{a}/{b} = ");
            //    Console.WriteLine(a / b);
            //}
            //else
            //{
            //    Console.WriteLine("Du kan ikke dividere med 0!");
            //}

            //Console.ReadKey();

            //Opgave 6.6-6.7
            float weight;
            var express = false;

            Console.Write("Input vægt i gram: ");
            weight = float.Parse(Console.ReadLine());
            Console.Write("Express? J/N: ");
            if (Console.ReadLine() == "J")
            {
                express = true;
            }

            if (weight < 20)
            {
                if (express == true)
                {
                    Console.WriteLine($"{5 * 1.5} kr.");
                }
                else
                {
                    Console.WriteLine("Pris: 5,00 kr.");
                }
            }
            else if (weight < 50)
            {
                if (express == true)
                {
                    Console.WriteLine($"{7 * 1.5} kr.");
                }
                else
                {
                    Console.WriteLine("Pris: 7,00 kr.");
                }
            }
            else if (weight < 100)
            {
                if (express == true)
                {
                    Console.WriteLine($"{10 * 1.5} kr.");
                }
                else
                {
                    Console.WriteLine("Pris: 10,00 kr.");
                }
            }
            else if (weight < 150)
            {
                if (express == true)
                {
                    Console.WriteLine($"{15 * 1.5} kr.");
                }
                else
                {
                    Console.WriteLine("Pris: 15,00 kr.");
                }
            }
            else if (weight < 200)
            {
                if (express == true)
                {
                    Console.WriteLine($"{20 * 1.5} kr.");
                }
                else
                {
                    Console.WriteLine("Pris: 20,00 kr.");
                }
            }
            else
            {
                if (express == true)
                {
                    Console.WriteLine($"{30 * 1.5} kr.");
                }
                else
                {
                    Console.WriteLine("Pris: 30,00 kr.");
                }
            }

            Console.ReadKey();
        }
    }
}
