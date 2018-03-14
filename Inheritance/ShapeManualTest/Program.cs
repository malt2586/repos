using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeEntities;

namespace ShapeManualTest
{
    class Program
    {
        static List<Shape> shapes = new List<Shape>();

        static void Main(string[] args)
        {
            ConsoleMenu();
        }

        static void ConsoleMenu()
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose and option:");
                Console.WriteLine("[1] New Circle");
                Console.WriteLine("[2] New Rectangle");
                Console.WriteLine("[3] New Square");
                Console.WriteLine("[4] Shapes info");
                Console.WriteLine("[Escape] to exit");
                keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Input values (x, y, radius) and press enter after each value.");
                        Circle c = new Circle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                        shapes.Add(c);
                        Console.Clear();
                        Console.WriteLine(c.ToString());
                        Console.WriteLine("Area: " + Math.Round(c.CalculateArea()));
                        Console.WriteLine("Circumference: " + Math.Round(c.CalculateCircumference()));
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Input values (x, y, length, width) and press enter after each value.");
                        Rectangle r = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                        shapes.Add(r);
                        Console.Clear();
                        Console.WriteLine(r.ToString());
                        Console.WriteLine("Area: " + Math.Round(r.CalculateArea()));
                        Console.WriteLine("Circumference: " + Math.Round(r.CalculateCircumference()));
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Input values (x, y, length) and press enter after each value.");
                        Square s = new Square(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                        shapes.Add(s);
                        Console.Clear();
                        Console.WriteLine(s.ToString());
                        Console.WriteLine("Area: " + Math.Round(s.CalculateArea()));
                        Console.WriteLine("Circumference: " + Math.Round(s.CalculateCircumference()));
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine($"Total area: {Math.Round(shapes.Sum(x => x.CalculateArea()))}");
                        Console.WriteLine($"Total circumference: {Math.Round(shapes.Sum(x => x.CalculateCircumference()))}");
                        Console.WriteLine($"Number of shapes: {shapes.Count}");
                        Console.WriteLine($"Number of circles: {shapes.Count(x => x is Circle)}");
                        Console.WriteLine($"Number of rectangles: {shapes.Count(x => x is Rectangle)}");
                        Console.WriteLine($"Number of squares: {shapes.Count(x => x is Square)}");
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
