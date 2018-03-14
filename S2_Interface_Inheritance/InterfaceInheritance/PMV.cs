using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    class PMV : BeltedVehicle
    {
        // FIELDS
        private int amountOfPassengers;
        private bool isAmphibious;

        // PROPERTIES
        public int AmountOfPassengers { get => amountOfPassengers; set => amountOfPassengers = value; }
        public bool IsAmphibious { get => isAmphibious; set => isAmphibious = value; }

        // CONSTRUCTORS
        public PMV(int amountOfPassengers, bool isAmphibious, bool hasWheels, bool isAbleToDrive, decimal price, int beltLength, int beltWidth, int weight, int horsePower) 
            : base(hasWheels, isAbleToDrive, price, beltLength, beltWidth, weight, horsePower)
        {
            AmountOfPassengers = amountOfPassengers;
            IsAmphibious = isAmphibious;
        }

        // METHODS
        public string DriveThroughTerrain()
        {
            return "Drives through the terrain.";
        }
    }
}
