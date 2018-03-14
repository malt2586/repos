using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string str;

            using (StreamReader reader = new StreamReader("numbers.txt"))
            {
                str = reader.ReadToEnd();
            }

            char[] chars = str.ToCharArray();

            ////DAY 1 PART 1
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    if (i == chars.Length - 1 && chars[i] == chars[0])
            //    {
            //        sum = sum + char.GetNumericValue(chars[i]);
            //    }
            //    else if (chars[i] == chars[i + 1])
            //    {
            //       sum = sum + char.GetNumericValue(chars[i]);
            //    }
            //}

            ////DAY 1 PART 2
            for (int i = 0; i < chars.Length; i++)
            {
                if (i + (chars.Length / 2) > chars.Length)
                {
                    if (chars[i] == chars[i - (chars.Length / 2)])
                    {
                        sum = sum + char.GetNumericValue(chars[i]);
                    }
                }
                else if (i + (chars.Length / 2) < chars.Length)
                {
                    if (chars[i] == chars[i + (chars.Length / 2)])
                    {
                        sum = sum + char.GetNumericValue(chars[i]);
                    }
                }
            }

            //Wait for key press to exit
            Console.ReadKey();
        }
    }
}
