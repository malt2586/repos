using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30WPFFlightPlanner
{
    public class Luggage
    {
        //PROPERTIES & FIELDS
        public int Weight { get; private set; }

        //CONSTRUCTORS
        public Luggage(int weight)
        {
            Weight = weight;
        }

        //METHODS
        public override string ToString()
        {
            return $"{Weight} kg";
        }
    }
}
