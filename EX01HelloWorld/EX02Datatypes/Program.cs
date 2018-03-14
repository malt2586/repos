using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 2.1
            string fornavn;
            string efternavn;
            int alder;

            fornavn = "Karsten";
            efternavn = "Hansen";
            alder = 35;

            Console.WriteLine(fornavn);
            Console.WriteLine(efternavn);
            Console.WriteLine(alder);

            Console.WriteLine($"{fornavn} {efternavn} {alder}");

            //Opgave 2.2
            string bogTitel = "Lord of The Rings";
            long ISBNnummer = 9780007117116;
            int sider = 400;
            double pris = 249.95;

            Console.WriteLine(bogTitel);
            Console.WriteLine(ISBNnummer);
            Console.WriteLine(sider);
            Console.WriteLine(pris);

            //Opgave 2.3
            Console.WriteLine($"int max: {int.MaxValue}");
            Console.WriteLine($"int min: {int.MinValue}");
            Console.WriteLine($"uint max: {uint.MaxValue}");
            Console.WriteLine($"uint min: {uint.MinValue}");
            Console.WriteLine($"long max: {long.MaxValue}");
            Console.WriteLine($"long min: {long.MinValue}");
            Console.WriteLine($"byte max: {byte.MaxValue}");
            Console.WriteLine($"byte min: {byte.MinValue}");
            Console.WriteLine($"short max: {short.MaxValue}");
            Console.WriteLine($"short min: {short.MinValue}");

            Console.ReadKey();
        }
    }
}
