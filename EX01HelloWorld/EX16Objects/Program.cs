using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarHandler;

namespace EX16Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Opgave 16.1
            ////Create new object of class "Car"
            //Car car = new Car("Ford", "Mustang", 1966, "Rød");

            ////Print Car "car" using method ToString()
            //Console.WriteLine(car.ToString());
            //Console.WriteLine("\n");

            ////Print Car "car" using method GetInfo()
            //Console.WriteLine(car.GetInfo());
            //Console.WriteLine("\n");

            ////Sets color of car
            //car.Color = "Blå";

            ////Prints return value of StartCar() to console
            //Console.WriteLine(car.StartCar());
            //Console.WriteLine("\n");

            ////Opgave 16.2
            ////Creates list for cars
            //List<Car> cars = new List<Car>();

            ////Creates cars
            //Car car1 = new Car("Ford", "Mustang", 1996, "Rød");
            //Car car2 = new Car("Porsche", "911", 2004, "Sølv");

            ////Adds cars to list
            //cars.Add(car1);
            //cars.Add(car2);

            ////Prints the cars (with color)
            //Console.WriteLine("Informationer om bilerne:");
            //foreach (Car c in cars)
            //{
            //    Console.WriteLine(c.GetInfo());
            //}
            //Console.WriteLine();

            ////Prints the cars (without color)
            //foreach (Car c in cars)
            //{
            //    Console.WriteLine(c);
            //}

            //Opgave 16.3
            //Creates list for cars
            List<Car> carList = new List<Car>();
            carList.Add(new Car("Ford", "Mustang", 1969, "Sølv"));

            //Print user input options to console
            Console.Write("Hej og velkommen til biladministrationen version 2017 \nDu har nu to muligheder. Ønsker du at: \nIndtaste en bil? (1) \nSe informationer om alle biler? (2) \nSøge efter et bilmærke? (3) \nIndtast dit ønske: ");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            //Menu user input switch
            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\n");
                    Console.WriteLine("Du ønsker at oprette en bil.");
                    Console.Write("Indtast mærke: ");
                    string make = Console.ReadLine();
                    Console.Write("Indtast model: ");
                    string model = Console.ReadLine();
                    Console.Write("Indtast årgang: ");
                    int productionYear = int.Parse(Console.ReadLine());
                    Console.Write("Indtast farve: ");
                    string color = Console.ReadLine();
                    Car car = new Car(make, model, productionYear, color);
                    carList.Add(car);
                    bool carStart = false;
                    int tryStart = 0;
                    while (carStart == false)
                    {
                        carStart = car.StartCar();
                        tryStart++;
                    }
                    Console.WriteLine($"{car.ToString()} brugte {tryStart} forsøg på at starte.");
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("\n");
                    foreach (Car c in carList)
                    {
                        Console.WriteLine(c.GetInfo());
                    }
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("\n");
                    Console.Write("Søg efter: ");
                    string searchKey = Console.ReadLine();
                    Console.WriteLine($"Alle biler af \"{searchKey}\": ");
                    foreach (Car c in carList)
                    {
                        Car result = carList.Find(x => x.Make.Equals(searchKey, StringComparison.InvariantCultureIgnoreCase));
                        if (result != null)
                        {
                            Console.WriteLine(result.GetInfo());
                        }
                    }
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();
                    break;
                default:
                    break;
            }

            //Wait for key press to exit
            Console.ReadKey();
        }
    }
}
