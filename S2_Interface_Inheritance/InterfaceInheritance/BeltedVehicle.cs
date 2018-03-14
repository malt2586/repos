using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    class BeltedVehicle : IVehicle
    {
        // FIELDS
        private bool hasWheels;
        private bool isAbleToDrive;
        private decimal price;
        private int beltLength;
        private int beltWidth;
        private int weight;
        private int horsePower;

        // PROPERTIES
        public bool HasWheels { get => hasWheels; set => hasWheels = value; }
        public bool IsAbleToDrive { get => isAbleToDrive; set => isAbleToDrive = value; }
        public decimal Price { get => price; set => price = value; }
        public int BeltLength { get => beltLength; set => beltLength = value; }
        public int BeltWidth { get => beltWidth; set => beltWidth = value; }
        public int Weight { get => weight; set => weight = value; }
        public int HorsePower { get => horsePower; set => horsePower = value; }

        // CONSTRUCTORS
        public BeltedVehicle(bool hasWheels, bool isAbleToDrive, decimal price, int beltLength, int beltWidth, int weight, int horsePower)
        {
            HasWheels = hasWheels;
            IsAbleToDrive = isAbleToDrive;
            Price = price;
            BeltLength = beltLength;
            BeltWidth = beltWidth;
            Weight = weight;
            HorsePower = horsePower;
        }
    }
}
