using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Box
    {
        //STATIC FIELDS
        private static decimal Weight5Price = 30;
        private static decimal Weight10Price = 45;
        private static decimal Weight20Price = 55;
        private static decimal Weight20PlusPrice = 65;
        private static decimal ExtraSizePrice = 40;
        private static int MaxSize = 200;

        //PROPERTIES
        private int length;

        public int Length
        {
            get { return length; }
            set
            {
                length = value;
            }
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public double Weight { get; set; }
        public decimal Price { get; set; }

        //CONSTRUCTORS
        public Box(int length, int height, int width, double weight)
        {
            Length = length;
            Height = height;
            Width = width;
            Weight = weight;
            Price = CalculatePrice();
        }

        //METHODS
        public decimal CalculatePrice()
        {
            List<int> boxDimensions = new List<int>() { Length, Height, Width };

            decimal price = 0;

            if (boxDimensions.OrderByDescending(z => z).Take(2).Sum() > MaxSize)
            {
                price += ExtraSizePrice;
            }

            if (Weight < 5)
            {
                price += Weight5Price;
            }
            else if (Weight < 10)
            {
                price += Weight10Price;
            }
            else if (Weight < 20)
            {
                price += Weight20Price;
            }
            else
            {
                price += Weight20PlusPrice;
            }

            return price;
        }

        public override string ToString()
        {
            return $"{Length}x{Width}x{Height} - {Weight} kg - {Price:C2}";
        }
    }
}
