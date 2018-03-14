using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraEX02Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 2.1
            //Trekant A
            Console.WriteLine("A");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

            //Trekant B
            Console.WriteLine("B");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 8; col > row; col--)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            //Trekant C
            Console.WriteLine("C");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write("  ");
                }
                for (int col = 8; col > row; col--)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            //Trekant D
            Console.WriteLine("D");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 8; col > row; col--)
                {
                    Console.Write("  ");
                }
                for (int col = 0; col < row; col++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            //Opgave 2.2
            //Figur A
            Console.WriteLine("A");
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (row == 0 || row == 6 || col == 0 || col == 6)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            //Figur B
            Console.WriteLine("B");
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (row == 0 || row == 6 || col == row)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            //Figur C
            Console.WriteLine("C");
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (row == 0 || row == 6 || col + row == 6)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            //Figur D
            Console.WriteLine("D");
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (row == 0 || row == 6 || col + row == 6 || col == row)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            //Figur D
            Console.WriteLine("E");
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (row == 0 || row == 6 || col == 0 || col == 6 || col + row == 6 || col == row)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            //Opgave 2.3
            //Figur A
            Console.WriteLine("A");
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 11; col++)
                {
                    if (col >= row && col + row <= 10)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            //Figur B
            Console.WriteLine("B");
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 11; col++)
                {
                    if (col + row >= 5 && col <= row + 5)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            //Figur C
            Console.WriteLine("C");
            for (int row = 0; row < 11; row++)
            {
                for (int col = 0; col < 11; col++)
                {
                    if (row < 6)
                    {
                        if (col + row >= 5 && col <= row + 5)
                        {
                            Console.Write("# ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    else
                    {
                        if (col + 5 >= row && col + row <= 15)
                        {
                            Console.Write("# ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    
                }
                Console.WriteLine();
            }
            //Opgave 2.4
            //Figur A
            Console.WriteLine("A");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (col <= row)
                    {
                        Console.Write($"{col + 1} ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            //Figur B
            Console.WriteLine("B");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (col >= row)
                    {
                        Console.Write($"{col - row + 1} ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            //Figur C
            Console.WriteLine("C");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (col + row >= 7 )
                    {
                        Console.Write($"{8 - col} ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            //Figur D
            Console.WriteLine("D");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (col + row < 8)
                    {
                        Console.Write($"{8 - (col + row)} ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            //Figur E
            Console.WriteLine("E");
            for (int row = 0; row < 8; row++)
            {
                int colNum = 1;
                for (int col = 0; col < 15; col++)
                {
                    if (col + row >= 7 && col <= row + 7)
                    {
                        Console.Write($"{colNum} ");
                        if (col < 7)
                        {
                            colNum++;
                        }
                        else
                        {
                            colNum--;
                        }
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            //Figur F
            Console.WriteLine("F");
            for (int row = 0; row < 8; row++)
            {
                int colNum = 1;
                for (int col = 0; col < 15; col++)
                {
                    if (col >= row && col + row <= 14)
                    {
                        Console.Write($"{colNum} ");
                        if (col < 7)
                        {
                            colNum++;
                        }
                        else
                        {
                            colNum--;
                        }
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            //Figur G
            Console.WriteLine("G");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 15; col++)
                {
                    if (col <= row || col + row >= 14)
                    {
                        if (col < 8)
                        {
                            Console.Write($"{col + 1} ");
                        }
                        else
                        {
                            Console.Write($"{15 - col} ");
                        }
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            //Figur H
            Console.WriteLine("H");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 15; col++)
                {
                    if (col + row > 7 && col < row + 7)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        if (col < 8)
                        {
                            Console.Write($"{col + 1} ");
                        }
                        else
                        {
                            Console.Write($"{15 - col} ");
                        }
                    }
                }
                Console.WriteLine();
            }
            //Figur I
            int runNum = 0;
            Console.WriteLine("I");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 15; col++)
                {
                    if (col + row >= 7 && col <= row + 7)
                    {
                        if (col <= 7)
                        {
                            if (runNum == 9)
                            {
                                runNum = 0;
                            }
                            else
                            {
                                runNum++;
                            }
                        }
                        else if (col > 7)
                        {
                            if (runNum == 0)
                            {
                                runNum = 9;
                            }
                            else
                            {
                                runNum--;
                            }
                        }
                        Console.Write($"{runNum} ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
