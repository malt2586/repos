using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07BooleanAlgebra
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;

            //Opgave 7.1
            Console.WriteLine($"a == b: {a == b}"); //false
            Console.WriteLine($"a > b: {a > b}"); //false
            Console.WriteLine($"a <= b: {a <= b}"); //true
            Console.WriteLine($"a - b > 0: {a - b > 0}"); //false
            Console.WriteLine($"a + b > 0: {a + b > 0}"); //true
            Console.WriteLine($"a > 1 - b: {a > 1 - b}"); //true
            Console.WriteLine();

            //Opgave 7.2
            Console.WriteLine(a == b || a > 0); //true
            Console.WriteLine(a + b > 0 && a > 0); //true
            Console.WriteLine(a == 5 && a + b > 0); //false
            Console.WriteLine((true || false) && a > b); //false
            Console.WriteLine(3 > 5 && true || a == b); //false
            Console.WriteLine(b > a && true || false || b > 4); //true
            Console.WriteLine(b < 4 && a < b || a + b > 4 && true); //true
            Console.WriteLine(true && true || false); //true
            Console.WriteLine(true && false && true); //false
            Console.WriteLine(true || false || false); //true
            Console.WriteLine(false && false); //false

            Console.ReadKey();
        }
    }
}
