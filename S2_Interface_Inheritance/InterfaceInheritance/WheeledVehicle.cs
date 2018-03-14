using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    class WheeledVehicle : IVehicle
    {
        // FIELDS
        private bool hasWheels;
        private bool isAbleToDrive;
        private decimal price;
        private int amountOfWheels;
        private int wheelSize;

        // PROPERTIES
        public bool HasWheels { get => hasWheels; set => hasWheels = value; }
        public bool IsAbleToDrive { get => isAbleToDrive; set => isAbleToDrive = value; }
        public decimal Price { get => price; set => price = value; }
        public int AmountOfWheels { get => amountOfWheels; set => amountOfWheels = value; }
        public int WheelSize { get => wheelSize; set => wheelSize = value; }

        // CONSTRUCTORS
        public WheeledVehicle(bool hasWheels, bool isAbleToDrive, decimal price, int amountOfWheels, int wheelSize)
        {
            HasWheels = hasWheels;
            IsAbleToDrive = isAbleToDrive;
            Price = price;
            AmountOfWheels = amountOfWheels;
            WheelSize = wheelSize;
        }

        // METHODS
        public string Drive(string direction)
        {
            return $"The vehicle uses {AmountOfWheels} wheels to drive {direction}";
        }
    }
}
