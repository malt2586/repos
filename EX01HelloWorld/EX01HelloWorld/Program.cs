using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 1.1
            string schoolName = "AspIT";
            string motto = "Fokuseret Talent";

            Console.WriteLine(schoolName);

            //Opgave 1.2
            schoolName = "AspIT - Nordjylland";
            Console.WriteLine(schoolName);

            //Opgave 1.3-1.4
            Console.Write(schoolName);
            Console.Write(" ");
            Console.WriteLine(motto);

            //Opgave 1.5
            Console.WriteLine($"{schoolName}, er en skole i Alborg. Mottoet for skolen er: {motto}.");

            Console.ReadKey();
        }
    }
}
