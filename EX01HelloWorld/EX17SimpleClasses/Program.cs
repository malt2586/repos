using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX17SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 17.1
            //Create new object of class "Box"
            Box box = new Box
            {
                Height = 40,
                Length = 60,
                Width = 20
            };

            //Print properties of object "box" to console
            Console.Write($"Kassen har følgende mål:\nHøjde: {box.Height} cm\nLængde: {box.Length} cm\nBredde: {box.Width} cm");
            Console.WriteLine("\n");

            //Opgave 17.2
            box.PrintInfo();
            Console.WriteLine("\n");

            //Opgave 17.3
            box.CalculateVolume();
            box.PrintInfo();
            Console.WriteLine("\n");

            //Opgave 17.4
            box.CalculateSurface();
            box.PrintInfo();
            Console.WriteLine("\n");

            //Wait for key press to exit
            Console.ReadKey();
        }
    }
}
