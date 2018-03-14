using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.BasicOOP.OOPTest
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime manufacturingDate { get; set; }

        public TimeSpan CurrentAge()
        {
            TimeSpan carAge = DateTime.Now.Subtract(manufacturingDate);
            return carAge;
        }

        public override string ToString()
        {
            return $"{Make} - {Model} - {manufacturingDate} - Age: {CurrentAge()}";
        }
    }
}
