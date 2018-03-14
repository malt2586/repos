using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 18.1
            //Creates new object of class "Car" and assigns values to properties
            Car car1 = new Car();
            car1.Make = "Dacia";
            car1.Model = "Logan";
            car1.Color = "Beige";
            car1.Price = 170000;
            car1.IsSold = false;

            //Creates new object of class "Car" and assigns values to properties
            Car car2 = new Car();
            car2.Make = "Toyota";
            car2.Model = "Yaris";
            car2.Color = "Rød";
            car2.Price = 89000;
            car2.IsSold = true;

            car1.PrintInfo();

            car2.PrintInfo();

            //Opgave 18.2
            //Creates new object of class "Car" using constructor "Car(string, string, string, int, bool)"
            Car myCar = new Car("Honda", "Civic", "Hvid", 199000, false);

            myCar.PrintInfo();

            //Opgave 18.3
            //Calls ToString() for object "myCar" of class "Car" and prints to console
            Console.WriteLine(myCar);

            //Calls ToString() for object "myCar" of class "Car" and prints to console
            Console.WriteLine(myCar.ToString());

            //Opgave 18.4
            //Calls PutOnSale() for object "myCar" of class "Car"
            myCar.PutOnSale();

            myCar.PrintInfo();

            //Wait for key press to exit
            Console.ReadKey();
        }
    }
}
