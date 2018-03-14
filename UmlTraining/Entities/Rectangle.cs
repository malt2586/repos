using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rectangle
    {
        //FIELDS
        private double length;
        private double width;

        //PROPERTIES
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        //CONSTRUCTORS
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        //METHODS
        public double GetArea()
        {
            double area;
            area = Length * Width;
            return area;
        }
        public double GetPerimeter()
        {
            double perimeter;
            perimeter = 2 * (Length + Width);
            return perimeter;
        }
        public override string ToString()
        {
            string rectangle;
            rectangle = $"Rectangle[length:{Length}, width:{Width}]";
            return rectangle;
        }
    }
}
