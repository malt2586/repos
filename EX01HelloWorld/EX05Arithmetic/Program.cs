using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            float input1;
            float input2;

            Console.WriteLine("Lommeregner V.4");
            Console.Write("Input: ");
            input1 = float.Parse(Console.ReadLine());
            Console.Write("Input: ");
            input2 = float.Parse(Console.ReadLine());

            //Addition
            Console.Write($"{input1} + {input2} = ");
            Console.WriteLine(input1 + input2);
            //Subtraction
            Console.Write($"{input1} - {input2} = ");
            Console.WriteLine(input1 - input2);
            //Multiplikation
            Console.Write($"{input1} * {input2} = ");
            Console.WriteLine(input1 * input2);
            //Division
            Console.Write($"{input1} / {input2} = ");
            Console.WriteLine(input1 / input2);
            //Modulus
            Console.Write($"{input1} % {input2} = ");
            Console.WriteLine(input1 % input2);

            Console.ReadKey();
        }
    }
}
