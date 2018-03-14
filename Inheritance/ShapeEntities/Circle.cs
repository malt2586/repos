using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeEntities
{
    public class Circle : Shape
    {
        //PROPERTIES
        public double Radius { get; set; }

        //CONSTRUCTORS
        public Circle(int x, int y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        //METHODS
        public override double CalculateArea()
        {
            return (Math.Pow(Radius, 2) * Math.PI);
        }

        public override double CalculateCircumference()
        {
            return (2 * Radius * Math.PI);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Radius: {Radius}";
        }
    }
}
