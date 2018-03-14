using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    class Tractor : WheeledVehicle
    {
        // FIELDS
        private int horsePower;
        private bool hasPassengerSeat;
        private int height;
        private int wheelHeight;
        private int fuelVolume;

        // PROPERTIES
        public int HorsePower { get => horsePower; set => horsePower = value; }
        public bool HasPassengerSeat { get => hasPassengerSeat; set => hasPassengerSeat = value; }
        public int Height { get => height; set => height = value; }
        public int WheelHeight { get => wheelHeight; set => wheelHeight = value; }
        public int FuelVolume { get => fuelVolume; set => fuelVolume = value; }

        // CONSTRUCTOR
        public Tractor(int horsePower, bool hasPassengerSeat, int height, int wheelHeight, int fuelVolume, bool hasWheels, bool isAbleToDrive, decimal price, int amountOfWheels, int wheelSize) 
            : base(hasWheels, isAbleToDrive, price, amountOfWheels, wheelSize)
        {
            HorsePower = horsePower;
            HasPassengerSeat = hasPassengerSeat;
            Height = height;
            WheelHeight = wheelHeight;
            FuelVolume = fuelVolume;
        }

        // METHODS
        public string Refuel(int amount)
        {
            FuelVolume += amount;
            return $"Refueled with {amount} liters.";
        }
    }
}
