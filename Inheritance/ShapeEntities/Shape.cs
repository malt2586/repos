using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeEntities
{
    public abstract class Shape
    {
        //FIELDS
        protected int x;
        protected int y;

        //PROPERTIES
        public int X { get; set; }
        public int Y { get; set; }

        //CONSTRUCTORS
        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        //METHODS
        public abstract double CalculateArea();

        public abstract double CalculateCircumference();

        public override string ToString()
        {
            return $"Position: ({X},{Y})";
        }
    }
}
