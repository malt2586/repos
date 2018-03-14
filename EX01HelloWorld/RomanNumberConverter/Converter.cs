using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberConverter
{
    class Converter
    {
        //FIELDS
        private Dictionary<char, int> numbersDictionary;

        //CONSTRUCTORS
        public Converter()
        {
            numbersDictionary = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
        }

        //METHODS
        public int ToDecimal(string romanNumber)
        {
            int result = 0;

            for (int i = 0; i < romanNumber.Length; i++)
            {
                numbersDictionary.TryGetValue(romanNumber[i], out int curr);
                numbersDictionary.TryGetValue(romanNumber.ElementAtOrDefault(i + 1), out int next);

                if (curr < next)
                {
                    result = result - curr;
                }
                else
                {
                    result = result + curr;
                }
            }

            return result;
        }

        public string ToRoman(string decimalNumber)
        {
            string romanNumber = "";
            int.TryParse(decimalNumber, out int input);

            //Creates list for each "place"(units, tens, hundreds) from input
            List<int> listOfInts = new List<int>();
            int loopCount = 0;
            while (input > 0)
            {
                listOfInts.Add((input % 10) * (int)Math.Pow(10, loopCount));
                input = input / 10;
                loopCount++;
            }
            listOfInts.Reverse();
            //

            //
            foreach (int i in listOfInts)
            {
                Tuple<int, KeyValuePair<char, int>> bestMatch;
                int dif;
                FindBestMatch(i, out bestMatch, out dif);

                if (i == bestMatch.Item2.Value)
                {
                    romanNumber = $"{romanNumber}{bestMatch.Item2.Key}";
                }
                if (dif == i)
                {
                    romanNumber = $"{romanNumber}{bestMatch.Item2.Key}{bestMatch.Item2.Key}";
                }
            }

            return romanNumber;
        }
        //Finds best match for ToRoman() method
        private void FindBestMatch(int i, out Tuple<int, KeyValuePair<char, int>> bestMatch, out int dif)
        {
            bestMatch = null;
            dif = 0;
            foreach (var e in numbersDictionary)
            {
                dif = Math.Abs(i - e.Value);
                if (bestMatch == null || dif < bestMatch.Item1)
                {
                    bestMatch = Tuple.Create(dif, e);
                }
            }
        }
        //
        //
        public bool IsRoman(string romanNumber)
        {
            char[] input = romanNumber.ToArray();

            //Evaluates if characters are valid
            foreach (char c in input)
            {
                if (numbersDictionary.ContainsKey(c) == false)
                {
                    return false;
                }
            }

            //Evaluates if characters are repeated more than allowed 
            // V,L,D <= 1 counts
            // I,C <= 3 counts
            // X <= 4 counts
            // M ... counts
            foreach (char c in input)
            {
                int count = input.Count(f => f == c);

                switch (c)
                {
                    case 'I' when count > 3:
                        return false;
                    case 'V' when count > 1:
                        return false;
                    case 'X' when count > 4:
                        return false;
                    case 'L' when count > 1:
                        return false;
                    case 'C' when count > 3:
                        return false;
                    case 'D' when count > 1:
                        return false;
                    case 'M':
                        break;
                    default:
                        break;
                }
            }

            //Evaluates if previous character was subtracted
            foreach (char c in input)
            {

            }

            return true;
        }

        public bool IsDecimal(string decimalNumber)
        {
            if (int.TryParse(decimalNumber, out int input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
