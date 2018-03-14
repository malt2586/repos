using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(100, 30, 45, 1);
            Console.WriteLine(box);
            Console.ReadKey();
        }
    }
}
