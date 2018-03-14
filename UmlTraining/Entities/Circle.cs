using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Circle
    {
        //FIELDS
        private double radius;

        //PROPERTIES
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        //CONSTRUCTORS
        public Circle(double radius)
        {
            Radius = radius;
        }

        //METHODS
        public double GetArea()
        {
            double area;
            area = Math.Pow(Radius, 2) * Math.PI;
            return area;
        }
        public double GetCircumference()
        {
            double circumference;
            circumference = (2 * Radius) * Math.PI;
            return circumference;
        }
        public override string ToString()
        {
            string circle;
            circle = $"Circle[radius:{Radius}]";
            return circle;
        }
    }
}
