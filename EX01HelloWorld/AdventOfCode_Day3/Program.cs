using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 265149;

            int row = (int)Math.Round(Math.Sqrt(input));
            int col = row;

            int[,] grid = new int[row, col];

            grid[(row / 2), (col / 2)] = 1;

            Console.WriteLine(grid.Length);
            Console.WriteLine(grid.GetLength(0));
            Console.WriteLine(row / 2);

            Console.ReadKey();
        }
    }
}
