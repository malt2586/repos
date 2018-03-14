using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeEntities
{
    public class Rectangle : Shape
    {
        //PROPERTIES
        public double Length { get; set; }
        public double Width { get; set; }

        //CONSTRUCTORS
        public Rectangle(int x, int y, double length, double width) : base(x, y)
        {
            Length = length;
            Width = width;
        }
        
        //METHODS
        public override double CalculateArea()
        {
            return (Length * Width);
        }

        public override double CalculateCircumference()
        {
            return (2 * (Length + Width));
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Length: {Length}, Width: {Width}";
        }
    }
}
