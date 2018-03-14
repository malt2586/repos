using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    class Tank : BeltedVehicle
    {
        // FIELDS
        private int barrelLength;
        private decimal mainGunCaliber;

        // PROPERTIES
        public int BarrelLength { get => barrelLength; set => barrelLength = value; }
        public decimal MainGunCaliber { get => mainGunCaliber; set => mainGunCaliber = value; }

        // CONSTRUCTORS
        public Tank(int barrelLength, decimal mainGunCaliber, bool hasWheels, bool isAbleToDrive, decimal price, int beltLength, int beltWidth, int weight, int horsePower) 
            : base(hasWheels, isAbleToDrive, price, beltLength, beltWidth, weight, horsePower)
        {
            BarrelLength = barrelLength;
            MainGunCaliber = mainGunCaliber;
        }

        // METHODS
        public List<string> FireMainGun(int amountOfTimes)
        {
            string fireMainGun = $"Main gun fired with a caliber {MainGunCaliber} shell";
            List<string> fireList = new List<string>(amountOfTimes);
            for (int i = 0; i < amountOfTimes; i++)
            {
                fireList.Add(fireMainGun);
            }
            return fireList;
        }
    }
}
