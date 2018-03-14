using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18SimpleClasses
{
    class Car
    {
        //Opgave 18.1
        public string Make;
        public string Model;
        public string Color;
        public double Price;
        public bool IsSold;
        public bool IsOnSale;

        //Prints information on object to console
        public void PrintInfo()
        {
            if (IsSold)
            {
                Console.Write("SOLGT! ");
            }
            Console.WriteLine($"Bilen er en {Make} {Model} i farven {Color}. Prisen er {Price} DKK.");
        }

        //Constructor taking no parameters
        public Car()
        {

        }

        //Opgave 18.2
        //Constructor taking parameters (string, string, string, int, bool)
        public Car(string make, string model, string color, int price, bool isSold)
        {
            Make = make;
            Model = model;
            Color = color;
            Price = price;
            IsSold = isSold;
            IsOnSale = false;
        }

        //Opgave 18.3
        //Overrides inherited ToString() and returns a string
        public override string ToString()
        {
            return $"{Make} {Model}";
        }

        //Opgave 18.4
        //Sets property "IsOnSale" and subtracts 10% from property "Price"
        public void PutOnSale()
        {
            IsOnSale = true;
            Price = Price * 0.9;
        }
    }
}
