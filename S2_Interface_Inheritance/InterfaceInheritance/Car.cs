using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    class Car : WheeledVehicle
    {
        // FIELDS
        private int safetyRating;
        private int entrances;

        // PROPERTIES
        public int SafetyRating { get => safetyRating; set => safetyRating = value; }
        public int Entrances { get => entrances; set => entrances = value; }

        // CONSTRUCTORS
        public Car(int safetyRating, int entrances, bool hasWheels, bool isAbleToDrive, decimal price, int amountOfWheels, int wheelSize) 
            : base(hasWheels, isAbleToDrive, price, amountOfWheels, wheelSize)
        {
            SafetyRating = safetyRating;
            Entrances = entrances;
        }

        // METHODS
        public string GetSalesTale()
        {
            return "Some sales tale that will convince you to buy the car.";
        }
    }
}
