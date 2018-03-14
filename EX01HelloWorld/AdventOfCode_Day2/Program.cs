using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rowList;

            int checksum = 0;
            int sumOfAll = 0;
            

            //DAY 2 PART 1/2
            //Opens and closes the StreamReader
            using (StreamReader reader = new StreamReader(@"C:\Users\malt2586\source\repos\EX01HelloWorld\AdventOfCode_Day2\input.txt"))
            {
                //Runs untill the end of stream
                while (!reader.EndOfStream)
                {
                    //Reads line from stream to a string
                    string row = reader.ReadLine();

                    //Splits the string and converts it to a List<int>
                    rowList = Array.ConvertAll(row.Split('\t'), int.Parse).ToList();

                    //Sorts list descending
                    rowList.Sort();
                    rowList.Reverse();

                    //Finds highest and lowest value, calculates the difference, and adds it to checksum
                    checksum = checksum + (rowList.Max() - rowList.Min());

                    for (int i = 0; i < rowList.Count - 1; i++)
                    {
                        for (int j = i + 1; j < rowList.Count; j++)
                        {
                            if (rowList[i] % rowList[j] == 0)
                            {
                                sumOfAll = sumOfAll + (rowList[i] / rowList[j]);
                            }
                            
                        }
                    }
                }
            }

            //Wait for key press to exit
            Console.ReadKey();
        }
    }
}
