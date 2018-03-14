using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeEntities
{
    public class Square : Rectangle
    {
        //CONSTRUCTORS
        public Square(int x, int y, double length) : base(x, y, length, length)
        {

        }

        //METHODS
        public override string ToString()
        {
            return $"Position: ({X},{Y}), Length: {Length}";
        }
    }
}
