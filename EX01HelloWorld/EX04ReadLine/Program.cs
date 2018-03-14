using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 4.1
            string userInput;

            Console.WriteLine("Skriv tekst og tryk enter.");
            userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(userInput);

            Console.ReadKey();

            //Opgave 4.2
            string fornavn;
            string efternavn;

            Console.Clear();
            Console.WriteLine("Skriv fornavn:");
            fornavn = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Skriv efternavn:");
            efternavn = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Velkommen {fornavn} {efternavn}!");

            Console.ReadKey();

            //Opgave 4.3
            double input;

            Console.Clear();
            Console.WriteLine("Indtast tal:");
            input = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(input);

            Console.ReadKey();

            //Opgave 4.4
            double firkantH;
            double firkantW;
            double firkantAreal;

            Console.Clear();
            Console.WriteLine("Indtast længde:");
            firkantW = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Indtast højde:");
            firkantH = double.Parse(Console.ReadLine());
            Console.Clear();
            firkantAreal = firkantH * firkantW;
            Console.WriteLine(firkantAreal);

            Console.ReadKey();

            //Opgave 4.5
            Console.Clear();
            Console.WriteLine("     AA     ");
            Console.WriteLine("    A  A    ");
            Console.WriteLine("   A    A   ");
            Console.WriteLine("  AAAAAAAA  ");
            Console.WriteLine(" A        A ");
            Console.WriteLine("A          A");

            Console.ReadKey();
        }
    }
}
