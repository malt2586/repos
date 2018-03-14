using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StarTrek
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Name syntax strings
            //string maleSyntax = "[S|Sp|Sk|St|T] [a|e|i|o|u|y] [r|t|p|d|f|j|k|l|v|b|n|m] [a|e|i|o|u|y] [q|p|k|ck|l]";
            //string maleShortSyntax = "[S|Sp|Sk|St|T] [a|e|i|o|u|y] [q|p|k|ck|l]";
            //string femaleSyntax = "[T’|C] [P|K|Q] [a|e|i|o|u|y] [r|j|’p|k|l]";

            //Name syntax lists
            List<string> maleSyntaxList = new List<string> { "[S|Sp|Sk|St|T]", "[a|e|i|o|u|y]", "[r|t|p|d|f|j|k|l|v|b|n|m]", "[a|e|i|o|u|y]", "[q|p|k|ck|l]" };
            List<string> maleShortSyntaxList = new List<string> { "[S|Sp|Sk|St|T]", "[a|e|i|o|u|y]", "[q|p|k|ck|l]" };
            List<string> femaleSyntaxList = new List<string> { "[T’|C]", "[P|K|Q]", "[a|e|i|o|u|y]", "[r|j|’p|k|l]" };

            foreach (string name in NameGenerator(maleSyntaxList))
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }

        //Generates list of names from substring list
        static IEnumerable<string> NameGenerator(List<string> nameSyntax)
        {
            IEnumerable<string> namesReturn = new List<string> { null };

            foreach (List<string> list in GetNameSyntaxList(nameSyntax))
            {
                namesReturn = namesReturn.SelectMany(o => list.Select(s => o + s));
            }

            return namesReturn;
        }

        //Generates list of substrings from syntax list
        static List<List<string>> GetNameSyntaxList(List<string> nameSyntax)
        {
            List<List<string>> listCollection = new List<List<string>>();

            foreach (string subString in nameSyntax)
            {
                List<string> subStringList = Regex.Split(subString.Trim('[', ']'), @"\|").ToList();
                listCollection.Add(subStringList);
            }

            return listCollection;
        }

        //static List<string> StringToNames(string input)
        //{

        //    return null;
        //}

        //static List<string> Recursive(List<List<string>> list, int n)
        //{

        //    return null;
        //}
    }
}
