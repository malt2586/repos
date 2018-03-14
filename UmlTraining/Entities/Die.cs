using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Die
    {
        //FIELDS
        private Random rng = new Random();
        private byte currentFace;
        private byte sides;

        //PROPERTIES
        //public Random Rng
        //{
        //    get { return rng; }
        //    set { rng = value; }
        //}
        public byte CurrentFace
        {
            get { return currentFace; }
        }
        public byte Sides
        {
            get { return sides; }
        }

        //CONSTRUCTORS
        public Die()
        {
            this.sides = 6;
        }
        public Die(byte sides)
        {
            this.sides = sides;
        }

        //METHODS
        public byte Roll()
        {
            byte roll;
            roll = (byte)rng.Next(1, sides + 1);
            currentFace = roll;
            return roll;
        }
    }
}
