using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.BasicOOP.Game
{
    class Die
    {
        //PROPERTIES
        public int Value { get; set; }

        //CONSTRUCTORS
        public Die() { }
        public Die(int initialValue)
        {
            Value = initialValue;
        }

        //METHODS
        public void Roll()
        {
            Value = new Random().Next(1, 7);
        }

        public override string ToString()
        {
            string roll = "";

            switch (Value)
            {
                case 1:
                    roll = "\n * \n";
                    break;
                case 2:
                    roll = "*\n\n  *";
                    break;
                case 3:
                    roll = "*\n *\n  *";
                    break;
                case 4:
                    roll = "* *\n\n* *";
                    break;
                case 5:
                    roll = "* *\n *\n* *";
                    break;
                case 6:
                    roll = "* *\n* *\n* *";
                    break;
                default:
                    break;
            }

            return roll;
        }
    }
}
